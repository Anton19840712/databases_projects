using System;
using MongoDB.Bson;
using MongoDB.Driver;

namespace LoookupAggregate
{
    public class Countries
    {
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