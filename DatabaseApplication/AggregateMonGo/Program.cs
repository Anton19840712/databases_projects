using System;
using System.Text.Json;
using Mongo.DAL.Models;
using Mongo.DAL.UnwindModel;
using MongoDB.Driver;

namespace AggregateMonGo
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new MongoClient();

            var monGoRepository = client.GetDatabase("test");

            var mongoCollectionPersonalities = monGoRepository.GetCollection<Personality>("personalities");

            var filterDefinition = Builders<Personality>.Filter.Eq(a => a.Id, 2);

            var items = mongoCollectionPersonalities.Aggregate()
                .Match(filterDefinition)
                .Unwind<Personality, PersonalityUnwind>(r => r.Friends).ToListAsync().Result;
                // In PersonalityUnwind you need the same name of the field as incoming collection!!! Or use attribute 
                //[{ "Id":2,"Name":"Anton","Surname":"Gridushko","Company":{ "Id":2,"Name":"Apple"},"Age":28,"Friends":{ "Id":2,"Name":"Victor"} },
                //{ "Id":2,"Name":"Anton","Surname":"Gridushko","Company":{ "Id":2,"Name":"Apple"},"Age":28,"Friends":{ "Id":3,"Name":"Billy"} },
                //{ "Id":2,"Name":"Anton","Surname":"Gridushko","Company":{ "Id":2,"Name":"Apple"},"Age":28,"Friends":{ "Id":4,"Name":"Oliver"} }]

                //.ReplaceRoot<object>("$Friends") As far as I could understand --->ReplaceRoot replaces patron root from the initial output.
                //[{ "_id":2,"Name":"Victor"},{ "_id":3,"Name":"Billy"},{ "_id":4,"Name":"Oliver"}]

            var jsonString = JsonSerializer.Serialize(items);

            Console.WriteLine(jsonString);

            //var group = new BsonDocument
            //{
            //    { "_id", "$_id" },
            //    { "root", new BsonDocument{ { "$mergeObjects", "$$ROOT" } } },
            //    {  "items", new BsonDocument{ { "$push", "$items" } } }
            //};

            //для потенциального изучения.
            //var orders = monGoRepository.GetCollection("orders").Aggregate()
            //    .Lookup("items", "items.itemId", "_id", @as: "items")
            //    .Unwind("items", new AggregateUnwindOptions<ItemDetail>() { PreserveNullAndEmptyArrays = true })
            //    .Lookup("vendors", "items.vendorId", "_id", @as: "items.vendor")
            //    .Unwind("items.vendor", new AggregateUnwindOptions<VendorDetail>() { PreserveNullAndEmptyArrays = true })
            //    .Group(group)
            //    .ReplaceRoot<object>("{$mergeObjects:['$root', '$$ROOT']}")
            //    .Project("{root:0}")
            //    .As<OrderDetail>().ToEnumerable();
        }
    }
}
