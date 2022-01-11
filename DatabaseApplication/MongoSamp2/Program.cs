using System;
using System.Collections.Generic;
using System.Dynamic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

//https://www.niceonecode.com/Blog/64/Left-Join-in-MongoDB-using-the-CSharp-driver-and-LINQ

namespace MongoSamp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new MonGoRepository("test"); //point the database we are going to connect

            //case sensitive on "cities" and name of fields also.
            //var result = db.FindRecords<Cities>("cities");

            //var result = db.FindRecords<CountriesDto>("countries");

            //var countriesWithCitiesList = db.JoinTables("countries");


            //UPSERT COMMAND:
            

            //1) Получаешь документ по определенному айди:
            var oneRec = db.FindRecordById<Cities>("cities", ObjectId.Parse("61d0c7732bc77ffed8a30dae"));


            //2) Меняешь определенное поле там:
            oneRec.City = "Brest";


            //3) Указываешь таблицу, указываешь айди модели, указываешь документ\рекорд\модель для обновления
            db.UpdateByInsertRecords("cities", oneRec.Id, oneRec);

            Console.WriteLine();
        }
    }


    [BsonIgnoreExtraElements]
    public class CountriesDto
    { 
        public ObjectId Id { get; set; }
        public string Country { get; set; }
        public int CountryNumber { get; set; }
    }

    public class Countries
    {
        [BsonId] // Like this we say mongo  database, that this field is and id of the object we are going to store
        public ObjectId Id { get; set; }
        public string Country { get; set; }
        public long CountryArea { get; set; }
        public int CountryNumber { get; set; }
    }

    public class Cities
    {
        //public ObjectId Id { get; set; }
        public ObjectId Id { get; set; }
        public string City { get; set; }
        public long Population { get; set; }
        public int CountryId { get; set; }
    }


    public class CitiesDto
    {
        public ObjectId Id { get; set; }
        public string City { get; set; }
        public int CountryId { get; set; }
    }

    public class CountriesCities : Countries
    {
        public IEnumerable<Cities> CountriesWithTheirCities { get; set; }
    }


    public class MonGoRepository
    {
        private readonly IMongoDatabase _db;

        public MonGoRepository(string database) // 0 hand over the name of the database
        {
            var client = new MongoClient();//1 create database client

            _db = client.GetDatabase(database); //2 create IMonGoDatabase _db

            //4 now you can use _db.GetCollection...
        }

        public void InsertRecord<T>(string table, T record)
        {
            var collection = _db.GetCollection<T>(table);

            collection.InsertOne(record);
        }

        public List<T> FindRecords<T>(string table)
        {
            var collection = _db.GetCollection<T>(table);

            return collection.Find(new BsonDocument()).ToList();
        }

        public T FindRecordById<T>(string table, ObjectId id)
        {
            var collection = _db.GetCollection<T>(table);

            var filter = Builders<T>.Filter.Eq("Id", id);

            return collection.Find(filter).First();
        }

        public void UpdateByInsertRecords<T>(string table, ObjectId id, T record)
        {
            var collection = _db.GetCollection<T>(table);
            
            var result = collection.ReplaceOne(new BsonDocument("_id", id), record, new UpdateOptions { IsUpsert = true });
        }

        //1
        //public IEnumerable<BsonDocument> JoinTables(string table)
        //{
        //    var mongoCollection = _db.GetCollection<Countries>("countries");

        //    var result = mongoCollection.Aggregate()
        //        .Lookup("cities", "CountryNumber", "CountryId", @as: "countiesWithTheirCities")
        //        .ToEnumerable();

        //    return result;
        //}

        //2
        //public IEnumerable<CountriesCities> JoinTables(string table)
        //{
        //    var countries = _db.GetCollection<Countries>("countries");

        //    var cities = _db.GetCollection<Cities>("cities");

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
        //    var countries = _db.GetCollection<Countries>("countries");

        //    var cities = _db.GetCollection<Cities>("cities");

        //    var result = countries.Aggregate().Lookup<Countries, Cities, CountriesCities>(cities,
        //            x => x.CountryNumber,
        //            x => x.CountryId,
        //            x => x.CountriesWithTheirCities).ToList();

        //    return result;
        //}


        public CountriesCities JoinTables(string table)
        {
            var countries = _db.GetCollection<CountriesDto>("countries");

            var cities = _db.GetCollection<CitiesDto>("cities");

            var result = countries.Aggregate().Lookup<CountriesDto, CitiesDto, CountriesCities>(cities,
                x => x.CountryNumber,
                x => x.CountryId,
                x => x.CountriesWithTheirCities).ToList().Find(x => x.Country == "USA");

            return result;
        }

    }
}
