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

            //UPDATE ONE ASYNC, PUSH:
            //This adds THE SAME object to the end of the array of Friends, in spite of the fact, target collection already
            //has the object with Id = 3
            //and the Name Irina.

            //mongoCollection.UpdateOneAsync(
            //    Builders<Person>.Filter.Eq(x => x.Id, 1),
            //    Builders<Person>.Update.Push(x => x.Friends, new Friend() 
            //        {
            //            Id = 3,
            //            Name = "Irina"
            //        }
            //    ));


            //UPDATE ONE ASYNC, ADD TO SET:
            //This one expression creates object only if Name or Id field is new for the target collection.
            //Otherwise it does not
            //mongoCollection.UpdateOneAsync(
            //    Builders<Person>.Filter.Eq(x => x.Id, 2),
            //    Builders<Person>.Update.AddToSet(x => x.Friends, new Friend()
            //    {
            //        Id = 4,
            //        Name = "Kate"
            //    }
            //    ));


            


            //UPDATE ONE ASYNC, ADD TO SET EACH:
            ////This one expression adds number of elements only if Name or Id is new for the target collection.
            //mongoCollection.UpdateOneAsync(
            //    Builders<Person>.Filter.Eq(x => x.Id, 1),
            //Builders<Person>.Update.AddToSetEach(x => x.Friends, new List<Friend>()
            //    {
            //        new Friend()
            //        {
            //            Id = 4,
            //            Name = "Vasilina"
            //        },
            //        new Friend()
            //        {
            //            Id = 4,
            //            Name = "Karina"
            //        },
            //        new Friend()
            //        {
            //            Id = 5,
            //            Name = "Anton"
            //        }
            //    }
            //);


            // REPLACE ONE ASYNC, UPSERT:
            // change target field of the model
            // we get the model
            // we change the field in it
            // we return it back to the database...:

            //var personId = 2;

            ////1) go to person with id = 2;
            //var filterPersonById = Builders<Person>.Filter.Eq(x => x.Id, personId);

            ////2) get this person 
            //var onePersonModelToUpdate = mongoCollection.FindAsync(filterPersonById).Result.FirstOrDefault();

            ////3) change the field on the client:
            //onePersonModelToUpdate.Age = 42;

            ////4) insert this field back with the model:
            //var result = mongoCollection
            //    .ReplaceOneAsync(new BsonDocument("_id", personId),
            //    onePersonModelToUpdate, new ReplaceOptions { IsUpsert = true });

            // INSERT ONE ASYNC:
            // just inserts new model in collection

            //var person = new Person
            //{
            //    Id = 12,
            //    Friends = new Friend[3] {new Friend() {Id = 4, Name = "Vasilina"},
            //                             new Friend() {Id = 4, Name = "Karina"},
            //                             new Friend() {Id = 5, Name = "Anton"}},
            //    Age = 34
            //};

            //mongoCollection.InsertOneAsync(person);
        }
    }
}
