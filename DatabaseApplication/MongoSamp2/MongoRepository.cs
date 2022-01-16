using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace MongoSamp2
{
    public class MonGoRepository
    {
        private readonly IMongoDatabase _monGoRepository;

        #region Constructor
        public MonGoRepository(string database) // 0 hand over the name of the database
        {
            var client = new MongoClient(); //1 create database client

            _monGoRepository = client.GetDatabase(database); //2 create IMonGoDatabase _monGoRepository

            //4 now you can use _monGoRepository.GetCollection...
        }
        #endregion

        #region UPDATE SPECIFIC BY ID IN ONE OBJECT
        public async Task<UpdateResult> UpdateManyByArrayOfIdFiltering(string table)
        {
            //1 get collection first as usual...:
            var collection = _monGoRepository.GetCollection<Person>(table);

            var filter = Builders<Person>.Filter.Eq(x => x.Id, 1);//заходим в единицу

            var update = Builders<Person>.Update.Set("Friends.$[f].Name", "Irina"); //будем обновлять там "Bob"
                                                                                    // но по отдельным идентификаторам
                                                                                    //alternative way
                                                                                    //var arrayFilters = new[]
                                                                                    //{
                                                                                    //    new BsonDocumentArrayFilterDefinition<BsonDocument>(
                                                                                    //        new BsonDocument("f._id",
                                                                                    //            new BsonDocument("$in", new BsonArray(new [] { 2, 4 })))),
                                                                                    //};

            var arrayFilters = new[]
            {
                new JsonArrayFilterDefinition<BsonDocument>(@"{ ""f._id"" : { $in : [ 2, 4 ] } }")
            };

            return await collection.UpdateOneAsync(filter, update, new UpdateOptions { ArrayFilters = arrayFilters });
        }
        #endregion
        
        #region UPDATE ALL IN ONE OBJECT
        public async Task<UpdateResult> UpdateManyFiltering(string table)
        {
            //1 get collection first as usual...:
            var collection = _monGoRepository.GetCollection<Person>(table);

            var filter = Builders<Person>.Filter.Eq(x => x.Id, 1);//Update many in only one.

            var update = Builders<Person>.Update.Set("Friends.$[].Name", "Veronica");//updates all names in node of Person with id = 1.

            await collection.UpdateOneAsync(filter, update);

            return await collection.UpdateOneAsync(filter, update);
        }
        #endregion

        #region UPDATE ONE IN ONE OBJECT
        public async Task<UpdateResult> UpdateElemMatchFiltering(string table)
        {
            //1 get collection first as usual...:
            var collection = _monGoRepository.GetCollection<Person>(table);

            var filter = Builders<Person> //идем в таблицу Person
                            .Filter.Eq(x => x.Id, 1) &  // берём в ней обект с айди == 1
                        Builders<Person>
                            .Filter.ElemMatch(x => x.Friends, // там же далее берем нод (ElemMatch) Friends
                        Builders<Friend>
                            .Filter.Eq(x => x.Id, 3));// и уже в нем фильтруемся по _id, которое 3

            var update = Builders<Person>.Update.Set(x => x.Friends[-1].Name, "Irina");// и заменяем его на Боб.

            return await collection.UpdateOneAsync(filter, update);
        }
        #endregion

        #region UPDATE ONE
        public async Task<UpdateResult> UpdateOneByFiltering(string table)
        {
            //1 get collection first as usual...:
            var collection = _monGoRepository.GetCollection<Member>(table);

            //2) write WHERE...:
            var filter = Builders<Member>.Filter.Eq(x => x.Id, 1) //first by id
                         & Builders<Member>.Filter.AnyEq(x => x.Friends, 10); //second by friends where value = 10

            //3) write WHAT in this 'where' we are going to update...:
            var update = Builders<Member>.Update.Set(x => x.Friends[-1], 999); //from previous existed 10 to 999

            var results = await collection.UpdateOneAsync(filter, update);

            return results;
        }
        #endregion

        #region SIMPLE FILTERING BY TEXT FIELD
        public List<string> FilterCollectionByTextField(string table)
        {
            //1) collecting...:
            var collection = _monGoRepository.GetCollection<Cities>(table);

            //2) creating filter...:
            // Note: to use text modifier you need to add text index into the chosen collection...:

            var filter = Builders<Cities>.Filter.Text("Brest");

            //3) filtering...:
            var results = collection.Find(Builders<Cities>.Filter.Text("Brest")).ToList().Select(x => x.City);

            var results2 = collection.AsQueryable()
                .Where(_ => filter.Inject())//you can use inject extension method to 
                .Select(x => x.City).ToList();

            return results2;
        } 
        #endregion

        public T FindRecordById<T>(string table, ObjectId id)
        {
            var collection = _monGoRepository.GetCollection<T>(table);

            var filter = Builders<T>.Filter.Eq("Id", id);

            return collection.Find(filter).First();
        }

        public void InsertRecord<T>(string table, T record)
        {
            var collection = _monGoRepository.GetCollection<T>(table);

            collection.InsertOne(record);
        }

        public List<T> FindRecords<T>(string table)
        {
            var collection = _monGoRepository.GetCollection<T>(table);

            return collection.Find(new BsonDocument()).ToList();
        }

        public void UpdateByInsertRecords<T>(string table, ObjectId id, T record)
        {
            var collection = _monGoRepository.GetCollection<T>(table);

            collection.ReplaceOne(new BsonDocument("_id", id), record, new UpdateOptions {IsUpsert = true});
        }

        //1
        //public IEnumerable<BsonDocument> JoinTables(string table)
        //{
        //    var mongoCollection = _monGoRepository.GetCollection<Countries>("countries");

        //    var result = mongoCollection.Aggregate()
        //        .Lookup("cities", "CountryNumber", "CountryId", @as: "countiesWithTheirCities")
        //        .ToEnumerable();

        //    return result;
        //}

        //2
        //public IEnumerable<CountriesCities> JoinTables(string table)
        //{
        //    var countries = _monGoRepository.GetCollection<Countries>("countries");

        //    var cities = _monGoRepository.GetCollection<Cities>("cities");

        //    var result = from o in countries.AsQueryable()
        //        join i in cities.AsQueryable()
        //            on o.CountryNumber equals i.CountryId
        //            into joinedCountries
        //        select new CountriesCities
        //        {
        //            Id = o.Id,
        //            Country = o.Country,
        //            CountryArea = o.CountryArea,
        //            CountryNumber = o.CountryNumber,
        //            CountriesWithTheirCities = joinedCountries
        //        };

        //    return result;
        //}


        //3 Здесь ты просто создаешь новую составную коллекцию 
        // Огромный объем данных приходит на бекенд.
        // Тебе же нужно запросить ровно только лишь то, что ты будешь отдавать на UI.

        //public IEnumerable<CountriesCities> JoinTables(string table)
        //{
        //    var countries = _monGoRepository.GetCollection<Countries>("countries");

        //    var cities = _monGoRepository.GetCollection<Cities>("cities");

        //    var result = countries.Aggregate().Lookup<Countries, Cities, CountriesCities>(cities,
        //            x => x.CountryNumber,
        //            x => x.CountryId,
        //            x => x.CountriesWithTheirCities).ToList();

        //    return result;
        //}


        public CountriesCities JoinTables(string table)
        {
            var countries = _monGoRepository.GetCollection<CountriesDto>("countries");

            var cities = _monGoRepository.GetCollection<CitiesDto>("cities");

            var result = countries.Aggregate().Lookup<CountriesDto, CitiesDto, CountriesCities>(cities,
                x => x.CountryNumber,
                x => x.CountryId,
                x => x.CountriesWithTheirCities).ToList().Find(x => x.Country == "USA");

            return result;
        }
    }
}