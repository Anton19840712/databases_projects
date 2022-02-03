using System.Collections.Generic;
using Mongo.DAL.Models;
using MongoDB.Driver;

namespace MonGoCreate
{
    class Program
    {
        static void Main(string[] args)
        {
            //db.pigments.insertOne( { _id: 1, colors: "blue, green, red" } )

            //{ _id: 2, item: "cable", tags: [ "electronics", "supplies" ] }

            //db.students.updateOne(
            //{ name: "joe" },
            //{ $push: { scores: { $each:[ 90, 92, 85 ] } } }
            //)

            //db.inventory.updateOne(
            //{ _id: 2 },
            //{ $addToSet: { tags: { $each:[ "camera", "electronics", "accessories" ] } } }
            //)

            var client = new MongoClient();

            var monGoRepository = client.GetDatabase("test");

            var mongoCollection34 = monGoRepository.GetCollection<Person>("persons").AsQueryable().ToList();

            var mongoCollection = monGoRepository.GetCollection<Person>("persons");

            ////This adds new object to the end of the array of Friends, in spite of the fact, target collection already has the object with Id = 3
            ////and the Name Irina.
            //mongoCollection.UpdateOneAsync(
            //    Builders<Person>.Filter.Eq(x => x.Id, 1),
            //    Builders<Person>.Update.Push(x => x.Friends, new Friend() 
            //        {
            //            Id = 3,
            //            Name = "Irina"
            //        }
            //    ));

            ////This one expression adds elements only if Name or Id is new for the target collection.
            //mongoCollection.UpdateOneAsync(
            //    Builders<Person>.Filter.Eq(x => x.Id, 1),
            //    Builders<Person>.Update.AddToSetEach(x => x.Friends, new List<Friend>()
            //        {
            //            new Friend()
            //            {
            //                Id = 4,
            //                Name = "Vasilina"
            //            },
            //            new Friend()
            //            {
            //                Id = 4,
            //                Name = "Karina"
            //            },
            //            new Friend()
            //            {
            //                Id = 5,
            //                Name = "Anton"
            //            }
            //        }

            //    ));

            //This one expression adds element only if Name or Id is new for the target collection.
            mongoCollection.UpdateOneAsync(
                Builders<Person>.Filter.Eq(x => x.Id, 1),
                Builders<Person>.Update.AddToSet(x => x.Friends, new Friend()
                {
                    Id = 4,
                    Name = "Antonina"
                }
                ));
        }
    }
}
