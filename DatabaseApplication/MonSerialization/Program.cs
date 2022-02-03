using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace MonSerialization
{

    public class Friend
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }


    public class Member
    {
        public int Id { get; set; }
        public int[] Friends { get; set; }
    }


    public class Personality
    {

        //[BsonElement("dealStatus")] //for correct mapping from the database
        //[JsonPropertyName("dealStatus")]



        //[BsonRepresentation(BsonType.ObjectId)] //how it should look in the database...:
        //[BsonId]
        [BsonElement("_id")]
        public long Id { get; set; }

        //[BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("Surname")]
        public string Surname { get; set; }

        [BsonIgnoreIfNull] //To avoid adding elements if null to the deserialized document
        public Company Company { get; set; }

        //[BsonRepresentation(BsonType.String)] stores as string in the database...:
        [BsonElement("Age")]
        [BsonIgnoreIfDefault] //To avoid adding elements if null to the deserialized document but for the VALUE TYPES...:
        public int Age { get; set; }

        [BsonElement("Languages")]
        public List<string> Languages { get; set; }
    }
    public class Company
    {
        [BsonId]
        [BsonElement("_id")]
        public int Id { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            var monGoRepository = new MonGoRepository("test");

            var element = monGoRepository.FindRecordById("personalities", 1);

            //serialization...: do not know how to work with this...:
            //I don't see the point in getting of BsonDocument.
            //Why, if after the .first we have a reduction of the document to our c# model.
            //Why we need serialize and deserialize...
            //var p = BsonSerializer.Deserialize<Personality>(element);
            //Console.WriteLine(p.ToJson());

            var elementBson = monGoRepository.BsonDocumentFindRecordById("personalities", 1);
            var p = BsonSerializer.Deserialize<Personality>(elementBson);

            Console.WriteLine($"{element.Name} {element.Age} {element.Company.Name}");
            Console.WriteLine(elementBson);
            Console.WriteLine(p.ToJson()); //Need we cast to json? Output is the same as in bson format...

            Console.WriteLine("===================================");

            // ✓✓✓✓ MAPPING...: DO NOT KNOW HOW THIS WORKS...:

            //BsonClassMap.RegisterClassMap<Personality>(cm =>
            //{
            //    cm.AutoMap();
            //    cm.MapMember(per => per.Name).SetElementName("Name");
            //});
            var person1 = new Personality { Name = "Bill", Age = 48 };

            Console.WriteLine("====================================");

            // ✓✓✓✓ insert many...:

            var personInsert1 = new Personality
            {
                Id = 9,
                //Note A: If we do not specify an ID,
                //then only the first one model with ID zero will be inserted from the collection.
                //All subsequent inserts will be ignored, regardless of changes to these properties.
                //So, we need to point Id...

                //Note B:
                //If the first id of the model is duplicated
                //- the second model is not inserted, even if its id is not duplicated
                Name = "Bill2234234",
                Surname = "Gridushko",
                Company = new Company { Name = "Apple" },
                Languages = new List<string>() { "Russian", "English", "German", "Italian" },
                Age = 48
            };

            var personInsert2 = new Personality
            {
                Id = 10,
                Name = "Angie234234",
                Surname = "Ivanova",
                Company = new Company { Name = "Google" },
                Languages = new List<string>() { "Russian", "English", "German", "Italian" },
                Age = 48
            };

            var clientMain = new MongoClient();

            var mainMonGoRepository = clientMain.GetDatabase("test");

            //GET 

            //GET BY ID...:

            //STACK OVERFLOW...:

            //var item = await collection
            //    .Find(Builders<ItemClass>.Filter.Eq("_id", id))
            //    .FirstOrDefaultAsync();


            // ✓✓✓✓ FIND AND UPDATE ASYNC...:

            //var filterDeal =
            //    Builders<UserProfile>.Filter.Eq("_id", dealId) &
            //    Builders<UserProfile>.Filter.Eq("documents.documentId", documentId);

            //var update = Builders<UserProfile>.Update.Set("documents.$[].verificationStatus", enumToInsert);

            //var resultOfStatusChanging = (await _unitOfWork.GetCollection<UserProfile>("UserProfile")
            //        .FindOneAndUpdateAsync(filterDeal, update.CurrentDate("LastModified"), new FindOneAndUpdateOptions<UserProfile> { ReturnDocument = ReturnDocument.After }))
            //    .Documents.FirstOrDefault(x => x.DocumentId == documentId)?.VerificationStatus;

            //_ret = $"Verification status of the file was updated to {resultOfStatusChanging}";

            //_code = 200;


            // ↑↑↑↑ insert many...

            //getting collection...:
            var collection = mainMonGoRepository.GetCollection<Personality>("personalities");

            collection.InsertManyAsync(new[] { personInsert1, personInsert2 });

            //collection.InsertOneAsync(person1);

            var arrayOfFruits = new string[] { "apple", "banana", "peach" };
            //collection.InsertOneAsync(person1);
            //collection.InsertOneAsync();

            // ↑↑↑↑ FIND AND UPDATE ASYNC...



            //MATCH SAMPLE
            //=====================
            //db.Trip.aggregate([ {$match: { countOffers: "2"} } ]) //{"countOffers":"2"}

            //db.cities.aggregate([
            //{ $match: { "City": { $in: ["Kiev", "Moskow"] } } }
            //])

            //another:
            //db.cities.aggregate([
            //{
            //    $match:
            //    {
            //        "continent": { $in: ["North America", "Asia"] }
            //    }
            //},
            //{
            //    $sort: { "population": -1 }
            //},
            //{
            //    $group:
            //    {
            //        "_id": {
            //            "continent": "$continent",
            //            "country": "$country"
            //        },
            //        "first_city": { $first: "$name" },
            //        "highest_population": { $max: "$population" }
            //    }
            //},
            //{
            //    $match:
            //    {
            //        "highest_population": { $gt: 20.0 }
            //    }
            //}
            //])


            //=====================


            //LOOKUP
            // Аналогичные запросы в разном синтаксисе.
            //var tripCollection = _unitOfWork.GetCollection<Trip>("Trip");

            //var elements = await _unitOfWork
            //    .GetCollection<Trip>("Trip").Aggregate()
            //    .Lookup(
            //        "Deal",
            //        "_id",
            //        "tripId",
            //        "tripsWithTheirDeals")
            //    .Project(Builders<BsonDocument>.Projection.Exclude("_id"))
            //    .ToListAsync();


            //var results = tripCollection.Aggregate().Lookup("Deal", "_id", "tripId", @as: "tripsWithTheirDeals").ToListAsync().Result;
            //var res34 = await tripCollection.Aggregate().Lookup("Deal", "_id", "tripId", @as: "tripsWithTheirDeals").ToListAsync();



            //PROJECTION SAMPLE

            //var projection = Builders<DealForIdDto>.Projection
            //    .Include(x => x.Id)
            //    .Include(x => x.TripId);

            //var projectionTrip = Builders<Trip>.Projection
            //    .Include(x => x.Id)
            //    .Include(x => x.StartDate)
            //    .Include(x => x.EndDate);

            //var allDealResults = await _unitOfWork.GetCollection<DealForIdDto>("Deal")
            //    .Find(Builders<DealForIdDto>.Filter.Empty)
            //    //.Project(projection)
            //    .ToListAsync()
            //    .ConfigureAwait(false);

            ////.Project("{startDate:1, endDate:1}")
            //var allTripsResults = await _unitOfWork.GetCollection<TripForIdDto>("Trip")
            //    .Find(Builders<TripForIdDto>.Filter.Empty)
            //    //.Project(projectionTrip)
            //    .ToListAsync()
            //    .ConfigureAwait(false);

            //foreach (var element in allDealResults)
            //{

            //    Console.WriteLine(element);
            //}




            // ✓✓✓✓ select all...:
            var collectionAll = mainMonGoRepository.GetCollection<Personality>("personalities");
            var filter = new BsonDocument();// -- mistake dont USE!!!
            //CREATE EMPTY DOCUMENT...:WITHOUT FILTERS
            //using var cursor = collectionAll.FindAsync(filter).Result;
            //while (cursor.MoveNext()) //MoveNextAsync
            //{
            //    var people = cursor.Current;
            //    foreach (Personality doc in people)
            //    {
            //        Console.WriteLine("{0} - {1} ({2})", doc.Id, doc.Name, doc.Age);
            //    }
            //}
            // ↑↑↑↑ select all...


            // ✓✓✓✓ FILTERS...:
            Console.WriteLine("=======================================");
            var collectionForFiltering = mainMonGoRepository.GetCollection<Personality>("personalities");

            //HERE WE POINT OUR FILTERS...:

            //1 ST NODE...:
            //var filterFiltering = new BsonDocument("Name", "Bill");
            //var filterFiltering = Builders<Personality>.Filter.Eq("Name", "Bill"); // text search...


            //operators samples...

            // GT
            //var filterFiltering = new BsonDocument("Age", new BsonDocument("$gt", 31));

            // LT
            //var filterFiltering = new BsonDocument("Age", new BsonDocument("$lt", 31));

            // GTE
            // var elements = new BsonDocument("Age", new BsonDocument("$gte", 31));
            // as a variant:
            var elements = new BsonDocument("$and", new BsonArray{ //$ in не получится.

                new BsonDocument("Age",new BsonDocument("$gte", 26)),
                new BsonDocument("Age", new BsonDocument("$lt", 33))
            });
            var collectionNew = collectionForFiltering.FindAsync(elements).Result.ToList();
            // see also DOUBLE FILTERING below...:
            var aspects = Builders<Personality>
                .Filter.Or(new List<FilterDefinition<Personality>> { elements });


            // OR =================================================

            // USING BSON DOCUMENT...:
            // OR - DOUBLE PARAMETERS FILTERING LIKE || in C#
            //------------------------------------------------------
            //var filterFiltering = new BsonDocument("$or", new BsonArray{

            //    new BsonDocument("Age",new BsonDocument("$gte", 33)),
            //    new BsonDocument("Name", "Tom")
            //});
            //------------------------------------------------------
            // OR ALTERNATIVE ...:
            var builder = Builders<BsonDocument>.Filter;
            //var filterFiltering = builder.Eq("Name", "Bill") | builder.Eq("Name", "Tom");
            //------------------------------------------------------
            // OR NOT...:
            //var filterFiltering = builder.Eq("Name", "Bill") | !builder.Eq("Name", "Tom"); //!←

            //the same, but using lambda...:
            //collection.Find(x=>x.Name=="Bill" && x.Age!=30).ToListAsync();
            //------------------------------------------------------
            // OR DOUBLE FILTERING...:
            var filter1 = Builders<Personality>.Filter.Eq("Name", "Tom");
            var filter2 = Builders<Personality>.Filter.Eq("Age", 28);
            //var filterFiltering = Builders<Personality>.Filter.Or(new List<FilterDefinition<Personality>> { filter1, filter2 });

            // AND =================================================

            // AND FROM ARRAY OF FILTERING CRITERIA...:
            //var filter3 = Builders<Personality>.Filter.Eq("Name", "Bill");
            //var filter44 = Builders<Personality>.Filter.In("Age", new List<BsonInt32>() { 28, 51 }); //this is not diapason.
            //var filter4 = Builders<Personality>.Filter.Not(Builders<Personality>.Filter.Eq("Surname", "Gridushko"));

            // NOT: возвращает документы, которые не попадают под определенное условие - то есть все остальные, которые не противоречат условию:
            // Если ты используешь только этот один фильтр, то он сработает как за исключением указанных критериев в фильтре.
            // Заметь, что здесь можно встроить фильтр в фильтре.
            //var filter4 = Builders<Personality>.Filter.Not(Builders<Personality>.Filter.Eq("Surname", "Gridushko"));

            //Странно, но all не отработает, нужно in. Видимо, all работает только по array. Да, действительно, all - только для array.
            //var filter434 = Builders<Personality>.Filter.All("Surname", new List<string>(){"Gridushko", "Gates"});
            var filter434 = Builders<Personality>.Filter.In("Surname", new List<string>(){"Gridushko", "Gates"});
            //var filter24 = Builders<Personality>.Filter.Eq("Surname", "Petrova");

            //var filterFiltering34 = Builders<Personality>.Filter.Or(new List<FilterDefinition<Personality>> { filter3, filter4 });

            //var filterFiltering334 = Builders<Personality>.Filter.And(new List<FilterDefinition<Personality>> { filter3, filter4 });


            //combining filters...:
            var filterFiltering2334 = Builders<Personality>.Filter.Or(
                //filter3, 
                //filter44, 
                //filter24
                //    ,
                //filter4
                filter434
                );

            var collectionNew3 = collectionForFiltering.FindAsync(filterFiltering2334).Result.ToList();


            //===================ALL - работает только по array.

            var collectionForFiltering23 = mainMonGoRepository.GetCollection<Member>("members");

            var filter43Ew4 = Builders<Member>.Filter.All("Friends", new List<BsonInt32>(){1, 3});

            var collectionNew33 = collectionForFiltering23.FindAsync(filter43Ew4).Result.ToList();


            //===================ALL
            //EXISTS, NOT EXISTS, WHERE, REGEX,
            //SIZE -- All documents with a number of elements
            //slice - , типа top 10. Или -10

            //============slice

            //too complex model for 

            //var monGoRepository2 = new MonGoRepository("skishift,");

            //var collectionForFiltering23e = monGoRepository2.GetCollection<Member>("members");

            //var filter43Ew4e = Builders<Member>.Filter.All("Friends", new List<BsonInt32>() { 1, 3 });

            //var collectionNew3ee3 = collectionForFiltering23.FindAsync(filter43Ew4e).Result.ToList();



            //============slice




            Console.WriteLine("2ND NODE....:");
            //2 ND NODE...:
            //var filterFiltering = new BsonDocument("Company.Name", "Microsoft");// 2nd node

            //ALL -- All documents with all array nodes...: -- работает только по массиву
            var filterFiltering = Builders<Personality>.Filter.All("Languages", 
                new List<string>()
                {
                    "English", "French"
                });

            // ANY IN...:
            //var filterFiltering = Builders<Personality>.Filter.AnyIn("Languages", new List<string>() { "English", "French" });

            // ONLY TWO LANGUAGES...:
            //var filterFiltering = Builders<Personality>.Filter.Size("Languages", 2);


            using var cursorFiltering = collectionForFiltering.FindAsync(filterFiltering).Result;

            while (cursorFiltering.MoveNext()) //MoveNextAsync
            {
                var people = cursorFiltering.Current;
                foreach (Personality doc in people)
                {
                    Console.WriteLine("{0} - {1} ({2})", doc.Id, doc.Name, doc.Age);
                }
            }
            // ↑↑↑↑ FILTERS...

            // ✓✓✓✓ SORTERS...:

            Console.WriteLine();
            Console.WriteLine("================================================");
            Console.WriteLine("SORT, SKIP, LIMIT, COUNT, FIRST, PROJECTION");
            // SORT, SKIP, LIMIT, COUNT, FIRST, PROJECTION ===============================================================

            //SORT COLLECTION BY FIELD AGE ASCENDING...:
            //var personalitiesCollection = collection.Find(new BsonDocument()).Sort("{Age:1}").ToListAsync().Result; //or Sort("{Age:-1}

            //ALTERNATIVELY INSTEAD OF -1/1...:SortByDescending, SortBy
            //сортировка по убыванию по свойству Name
            //var result1 = collection.Find(new BsonDocument()).SortByDescending(e => e.Name);
            //сортировка по возрастанию по свойству Age
            //var result2 = collection.Find(new BsonDocument()).SortBy(e => e.Age);

            //DOUBLE KEY SORTING...:

            //var sort = Builders<Personality>.Sort.Ascending("Company.Name").Descending("Age");
            //var personalitiesCollection = collection.Find(new BsonDocument()).Sort(sort).ToListAsync().Result;


            //SKIP, LIMIT

            var filterEmpty = new BsonDocument();
            var personalitiesCollection = collection.Find(filterEmpty).Skip(2).Limit(3).ToListAsync().Result;

            Console.WriteLine();
            foreach (var personality in personalitiesCollection)
            {
                Console.WriteLine("{0} - {1} ({2})", personality.Id, personality.Name, personality.Age);
            }

            //COUNT...:

            var number = collection.Find(filter).CountDocumentsAsync().Result;
            Console.WriteLine(number);

            //PROJECTION...:SUPER FOR DTO, I THINK...:
            //LIKE A CHUNK OF ONLY NEEDED PROPERTIES...:

            Console.WriteLine();
            Console.WriteLine("PROJECTION...");
            //db.students.find({}, {roll:1, _id:0}) 1- выберет все поля, 0 - не выберет это поле.
            var personalitiesCol = collection.Find(new BsonDocument()).Project("{Name:1, Age:1, _id:0}").ToListAsync().Result;
            personalitiesCol.ForEach(Console.WriteLine);

            //LIKE A MAPPING...:
            Console.WriteLine();
            Console.WriteLine("PROJECTION INTO EMPLOYEE MODEL...:");

            //projection instance creation...:
            var projection = Builders<Personality>.Projection.Expression(persona => new Employee { Name = persona.Name, Age = persona.Age });

            //projecting...:
            var employees = collection.Find(filter).Project<Employee>(projection).ToListAsync().Result;
            foreach (var e in employees)
            {
                Console.WriteLine("{0} - {1}", e.Name, e.Age);
            }


            // ↑↑↑↑ SORTERS...

            // ✓✓✓✓ GROUP...:

            //AGGREGATION...:
            Console.WriteLine();
            Console.WriteLine("GROUP...");
            var personalities = collection.Aggregate()
                .Group(new BsonDocument {
                    { "_id", "$Age" }, //← you want to see in output...← key --- value 
                    { "count", new BsonDocument("$sum", 1) } })//← you A: counting, B:  summing...← key --- value <---- this is a number of elements in a group...
                .ToListAsync().Result; //function sum is used for counting...:

            foreach (BsonDocument person in personalities)
            {
                Console.WriteLine("{0} - {1}",
                    person.GetValue("_id"), //outputs age(value) by key _id ↑ { "_id", "$Age" }
                    person.GetValue("count"));//outputs sum(value) by key count ↑ { "$sum", 1 }
            }

            //MATCH ----> FILTERING IN AGGREGATION...:
            //1st node and 2nd node...: <===== something similar to filtering by first node, then by the second...:
            var superCollection = collection.Aggregate()
                .Match(new BsonDocument { { "Name", "Tom" }, { "Company.Name", "Microsoft" } })
                .ToListAsync().Result;

            foreach (var item in superCollection)
            {
                Console.WriteLine("{0} - {1}", p.Name, p.Age);
            }

            //MATCH, THEN GROUP, THEN FILTERING WITH AGGREGATION...:
            var persons = collection.Aggregate()
                .Match(new BsonDocument { { "Name", "Tom" } })
                .Group(new BsonDocument
                {
                    { "_id", "$Company.Name" },
                    { "count", new BsonDocument("$sum", 1) }
                }).ToListAsync().Result;

            foreach (BsonDocument per in persons)
            {
                Console.WriteLine("{0} - {1}", per.GetValue("_id"), per.GetValue("count"));
            }
            // ↑↑↑↑ GROUP...




            // ✓✓✓✓ UPDATE...:

            //AddToSet: Adds new element in the node
            //ADDS NEW ELEMENTS to the document field that represents the array. For example, add a new line to the Languages array:
            Builders<BsonDocument>.Update.AddToSet("Languages", "Spanish");

            //Inc: Increments value. Let increase age by 2 
            //INCREMENTS the value of a numeric property by the specified number of units. For example, let's increase the value of the Age property by two units:
            Builders<BsonDocument>.Update.Inc("Age", 2);

            //Push: Adds new elements to the key that represents the array. For example:
            Builders<BsonDocument>.Update.Push("Languages", "French");

            //Pull: Removes a specific element from an array. For example:
            Builders<BsonDocument>.Update.Pull("Languages", "french");

            //Unset: Removes the key and its value. For example:
            Builders<BsonDocument>.Update.Unset("Age");

            //PopFirst: Selects the first element for a property that represents an array.

            //PopLast: Selects the last element for a property that represents an array.

            //NODE RENAMING: Renames the name of the key in the document. For example, let's rename the Age field to Year:
            Builders<BsonDocument>.Update.Rename("Age", "Year");

            //When updating, keep in mind that we cannot change the _id field. ↓↓↓↓↓↓↓↓↓↓↓↓

            // BY REPLACING WITH THE FULL MODEL...:
            var collectionOfPersons = mainMonGoRepository.GetCollection<BsonDocument>("personalities");

            var result34 = collectionOfPersons.ReplaceOneAsync(new BsonDocument("Name", "Tom"),
                //if in the collection a Tom name <------ replace the model where Tom with this one...:
                new BsonDocument
                {
                    {"Name","Tom K."},
                    {"Age", 40},
                    {"Languages", new BsonArray(new []{"english", "spanish"})},
                    { "Company",
                        new BsonDocument{
                            {"Name" , "Apple"}
                        }
                    }
                }).Result;

            Console.WriteLine("Found by criteria: {0}; updated: {1}", result34.MatchedCount, result34.ModifiedCount);

            var collectionOfPersonalities = collection.Find(new BsonDocument()).ToListAsync().Result;

            collectionOfPersonalities.ForEach(Console.WriteLine);


            // BY REPLACING USING REPLACE OPTIONS...:
            // Эта хрень вставляет Роберта со схемой айди Object - потом ничего не получается запарсить. 
            // Нужно удалить например, db.personalities.deleteOne({"Name":"Robert"}, {"Age":40})
            //var resultPersons = collectionOfPersons.ReplaceOneAsync(new BsonDocument("Name", "Bob"), 
            //    //if in the collection a Bob name <------ replace the model where Bob with this one...:
            //    new BsonDocument //to replace with it current document
            //    {
            //        {"Name","Robert"},
            //        {"Age", 40},
            //        {"Languages", new BsonArray(new []{"english", "spanish"})},
            //        { "Company", new BsonDocument{{"Name" , "Bob&Ron Inc."}}
            //        }
            //    }, new ReplaceOptions { IsUpsert = true }).Result;

            //{IsUpsert = true} <==== need to insert even if there is no matching data by criteria...:
            //If there is no such document - insert anyway a new one...:

            //Console.WriteLine("Id of the added object: {0}", resultPersons.UpsertedId);
            //<---------with UpsertedId we can get the Id of a newly inserted object...<---------


            //UPDATE ONE ASYNC...:

            //Could not use previous time, but using builder was ok
            //var result45 = collectionOfPersons.UpdateOneAsync(
            //    new BsonDocument("Name", "Tom"), //filter from: <---------
            //    new BsonDocument("$set", new BsonDocument("Age", 28))).Result; //to data: <---------

            //Console.WriteLine("Matched: {0}; Updated: {1}", result45.MatchedCount, result45.ModifiedCount);

            ////INC...:
            //var result123T = collection.UpdateOneAsync(
            //    new BsonDocument("Name", "Robert"),
            //    new BsonDocument("$inc", new BsonDocument("Age", 2))).Result;

            //===========

            //REAL SAMPLE
            //_ret = await _unitOfWork.GetCollection<Deal>("Deal")
            //    .UpdateOneAsync(
            //        Builders<Deal>.Filter.Eq("_id", id),
            //        Builders<Deal>.Update.Set("dealPipeLine", DealPipeLine.DealIsOver)
            //    );

            //_code = HttpStatusCode.OK;

            //===========


            ////THE SAME, BUT WITH USING OF BUILDER...:

            //// filter parameter...:
            //var filterLa = Builders<BsonDocument>.Filter.Eq("Name", "Tom");

            //// update parameter...:
            //var updateLa = Builders<BsonDocument>.Update.Set("Age", 30);
            //var result434 = collectionOfPersons.UpdateOneAsync(filterLa, updateLa).Result;


            //var filterMb = Builders<BsonDocument>.Filter.Eq("Company.Name", "Google");
            //var updateMb = Builders<BsonDocument>.Update.Set("Company.Name", "Google Inc.");
            //var resultMb = collectionOfPersons.UpdateOneAsync(filterMb, updateMb);


            //var builderSa = Builders<BsonDocument>.Filter;
            //var filterSa = builder.Eq("Name", "Tom") & builder.Eq("Age", 30);
            //var updateSa = Builders<BsonDocument>.Update.Set("Age", 33);
            //var resultSa = collectionOfPersons.UpdateOneAsync(filterSa, updateSa);

            ////UPDATE MANY ASYNC...:
            //var builderMn = Builders<BsonDocument>.Filter;
            //var filterMn = builder.Eq("Name", "Tom") | builder.Eq("Name", "John");
            //var updateMn = Builders<BsonDocument>.Update.Set("Age", 36);
            //var resultMn = collectionOfPersons.UpdateManyAsync(filterMn, updateMn);

            ////CURRENT DATA OF UPDATE...: SUPER↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓ USE IT
            //var filterSk = Builders<BsonDocument>.Filter.Eq("Name", "Tom");
            //var updateSk = Builders<BsonDocument>.Update.Set("Age", 30).CurrentDate("LastModified");//<========== here
            //var resultSk = collectionOfPersons.UpdateOneAsync(filterSk, updateSk);

            //UPDATING OF PO CO TYPES
            //Compare with bulk update... what is better?
            //Result ===> foreach object, where we have name: Bill we update age to 32...:... interesting...

            //UpdateManyAsync==> updates only one field...NOT BULK...:

            var filterMmm = Builders<Personality>.Filter.Eq("Name", "Bill");
            var updateMmm = Builders<Personality>.Update.Set(x => x.Age, 32);
            var resultMmm = collection.UpdateManyAsync(filterMmm, updateMmm).Result;

            Console.WriteLine("Matched: {0}; Updated: {1}", resultMmm.MatchedCount, resultMmm.ModifiedCount);

            // ↑↑↑↑ UPDATE...


            // ✓✓✓✓ DELETING...

            //DELETE ONE...:
            var filterDeleting = Builders<BsonDocument>.Filter.Eq("Name", "Tom K.");
            collectionOfPersons.DeleteOneAsync(filterDeleting);

            var peopleToPeople = collectionOfPersons.Find(new BsonDocument()).ToListAsync().Result;
            foreach (var pip in peopleToPeople)
                Console.WriteLine(p);

            //THE SAME... but wit collection of PO CO 
            collection.DeleteOneAsync(pip => pip.Name == "Tom K.");

            //DELETE MANY ASYNC...:
            var resultMany = collection.DeleteManyAsync(pip => pip.Name == "Billy").Result;
            Console.WriteLine("Deleted: {0}", resultMany.DeletedCount);

            // ↑↑↑↑ DELETING...



            // ✓✓✓✓ BULK WRITE ASYNC....:<<===== can delete, insert, update many fields in many by criteria 

            //1st sample
            //getting collection as usual...:

            //DELETING BY CRITERIA...:
            var collectionPersona = mainMonGoRepository.GetCollection<BsonDocument>("personalities");

            //BULK WRITE ASYNC...:
            var result = collectionPersona.BulkWriteAsync(new WriteModel<BsonDocument>[]
            {
                new DeleteOneModel<BsonDocument>(new BsonDocument("Name", "Robert"))
                //stay safe... stay calm, because there is no Robert in collection now... so, nothing to delete...)

            }).Result;

            Console.WriteLine("Deleted: {0}", result.DeletedCount);
            var peoplePersons = collection.Find(new BsonDocument()).ToListAsync().Result;
            foreach (var pip in peoplePersons) Console.WriteLine(pip);


            //2nd sample
            Console.WriteLine();

            Console.WriteLine("BULK...");

            //getting collection as usual...:
            var collectionPersonality = mainMonGoRepository.GetCollection<BsonDocument>("personalities");

            //creating filter...:
            //first we filter all the data in collection...:
            var filter34 = Builders<BsonDocument>.Filter.Eq("Company.Name", "Apple");

            //creating the update data...:
            var update34 = Builders<BsonDocument>.Update.Set("Company.Name", "Amazon");


            var newDoc = new BsonDocument
            {
                {"Name", "Bill"},
                {"Age", 32},
                {"Languages", new BsonArray{"english", "german"}},
                {"Company", new BsonDocument{
                    {"Name","Google"}
                }}
            };

            var result88 = collectionPersonality.BulkWriteAsync(new WriteModel<BsonDocument>[]
            {
                //new DeleteOneModel<BsonDocument>(new BsonDocument("Name", "Robert")),
                new UpdateManyModel<BsonDocument>(filter34, update34),
                //new InsertOneModel<BsonDocument>(newDoc)
            }).Result;

            Console.WriteLine("Deleted: {0}; Added: {1}; Updated: {2}",
                result88.DeletedCount, result88.InsertedCount, result88.ModifiedCount);

            // ↑↑↑↑ BULK WRITE ASYNC...


        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class MonGoRepository
    {
        private readonly IMongoDatabase _monGoRepository;
        public MonGoRepository(string database)
        {
            //string connectionString = "mongodb://localhost"; insert in MonGoClient() ↓↓

            var client = new MongoClient();

            _monGoRepository = client.GetDatabase(database);
        }

        public Personality FindRecordById(string table, long id)
        {
            var collection = _monGoRepository.GetCollection<Personality>(table);

            //var filter = Builders<Personality>.Filter.Eq("Id", id);

            var filterBson = new BsonDocument("_id", id); //case sensitive...← more elegant way...

            var results = collection.Find(filterBson).First();

            return results;
        }

        public BsonDocument BsonDocumentFindRecordById(string table, long id)
        {
            var collection = _monGoRepository.GetCollection<Personality>(table);

            //var filter = Builders<Personality>.Filter.Eq("Id", id); //eqvivalent ↓

            var filterBson = new BsonDocument("_id", id); //case sensitive...← more elegant way...

            var results = collection.Find(filterBson).First().ToBsonDocument();

            return results;
        }
    }
}
