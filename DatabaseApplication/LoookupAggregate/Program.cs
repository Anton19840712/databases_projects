using Mongo.DAL.Models;
using MongoDB.Driver;
//https://www.niceonecode.com/blog/72/mongodb-aggregation-array-to-object-id-with-three-collections-many-to-one-to-one-using-lookup
namespace LoookupAggregate
{
    public class PersonUnwind
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var client = new MongoClient();

            var monGoRepository = client.GetDatabase("test");

            var mongoCountriesCollection = monGoRepository.GetCollection<Countries>("countries");

            var result = mongoCountriesCollection.Aggregate()
                .Lookup("cities", "CountryNumber", "CountryId", @as: "countiesWithTheirCities")
                .ToListAsync().Result;

            //Result of joining...:
            //{
            //    "_id" : ObjectId("61d0c9a92bc77ffed8a30db6"), 
            //    "Country" : "Armenia", 
            //    "CountryNumber" : 1, 

            //    "countiesWithTheirCities" : [
            //    {
            //        "_id" : ObjectId("61d0c7732bc77ffed8a30db3"),
            //        "City" : "Yerevan", 
            //        "Population" : 1089181, 
            //        "CountryId" : 1
            //    }
            //    ]
            //}


            //// REAL SAMPLE:
            //var mongoCountriesCollection = _unitOfWork.Parcel;

            //var elements = _unitOfWork.Deal
            //    .Aggregate()
            //    .Lookup(
            //        "Parcel",
            //        "offers._id",
            //        "offerId", @as:
            //        "dealsAndOffersWithTheirParcels")
            //    .ToListAsync().Result;
        }
    }
}