using Mongo.DAL.Models;
using MongoDB.Driver;
//https://www.niceonecode.com/blog/72/mongodb-aggregation-array-to-object-id-with-three-collections-many-to-one-to-one-using-lookup
namespace LoookupAggregate
{

    class Program
    {
        static void Main(string[] args)
        {
            var client = new MongoClient();

            var monGoRepository = client.GetDatabase("test");

            var mongoCollection = monGoRepository.GetCollection<Countries>("countries");

            var result = mongoCollection.Aggregate()
                .Lookup("cities", "CountryNumber", "CountryId", @as: "countiesWithTheirCities")
                .ToListAsync().Result;


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
//В результате таблицы объединятся.
//{
//    {
//        "_id" : ObjectId("61d0c9a92bc77ffed8a30db6"), 
//        "Country" : "Armenia", 
//        "CountryNumber" : 1, 
//        "countiesWithTheirCities" : [

//            {
//                "_id" : ObjectId("61d0c7732bc77ffed8a30db3"), 
//                "City" : "Yerevan", 
//                "Population" : 1089181, 
//                "CountryId" : 1

//            }
//        ]
//    }
//}