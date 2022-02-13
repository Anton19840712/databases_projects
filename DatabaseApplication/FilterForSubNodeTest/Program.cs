using System.Collections.Generic;
using Mongo.DAL.Models;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace FilterForSubNodeTest
{
    
    


    class Program
    {
        private static IMongoDatabase _monGoRepository;

        static void Main(string[] args)
        {
            //var friendId = 2;

            var client = new MongoClient(); //1 create database client

            _monGoRepository = client.GetDatabase("test");

            var collection = _monGoRepository.GetCollection<Personality>("personalities");
            var elements = collection.AsQueryable().ToList();


            //===========================================>
            //attempt 3 - WORKING FOR THIS SAMPLE...:

            //var filterDeal =
            //    Builders<Personality>.Filter.Eq("_id", 1);

            //var update = Builders<Personality>.Update.Set("Friends.$[].Name", "Claudia");

            //var resultOfStatusChanging = collection
            //    .FindOneAndUpdateAsync(filterDeal, update, new FindOneAndUpdateOptions<Personality> { ReturnDocument = ReturnDocument.After }).Result;

            //===========================================>

            //attempt 2

            //var internalIds = new[] { 1, 2 };
            //var idFilter = Builders<Personality>.Filter.Eq(x => x.Id, 1);
            //var updateDefinition = Builders<Personality>.Update.Set("Friends.$[friend].Name", "Igor");

            //collection.UpdateManyAsync(idFilter, updateDefinition,
            //    new UpdateOptions
            //    {
            //        ArrayFilters = new[]
            //        {
            //            new BsonDocumentArrayFilterDefinition<BsonDocument>
            //                (new BsonDocument("friend._id",
            //                new BsonDocument("$in", new BsonArray(internalIds)))),
            //        }
            //    });





            //===========================================>
            //attempt 4 - WORKING FOR THIS SAMPLE...:

            //var filter = Builders<Personality>.Filter.Eq(x => x.Id, 1);

            //var update = Builders<Personality>.Update.Set("Friends.$[f].Name", "Maria");

            //var arrayFilters = new[]
            //{
            //    new JsonArrayFilterDefinition<BsonDocument>(@"{ ""f._id"" : { $in : [ 2, 4 ] } }")
            //};

            //collection.UpdateOneAsync(filter, update, new UpdateOptions { ArrayFilters = arrayFilters });

            //===========================================>



            //attempt 5 - WORKING FOR THIS SAMPLE...:

            //var internalIds = new[] { 2, 3 };

            //var filter = Builders<Personality>.Filter.Eq(x => x.Id, 1);

            //var update = Builders<Personality>.Update.Set("Friends.$[f].Name", "Anton");

            //var arrayFilters = new[]
            //{
            //    new BsonDocumentArrayFilterDefinition<BsonDocument>(
            //        new BsonDocument("f._id", new BsonDocument("$in", new BsonArray(internalIds)))),
            //};

            //collection.UpdateOneAsync(filter, update, new UpdateOptions { ArrayFilters = arrayFilters });

            //===========================================>

            ////attempt 6 - ...WORKING FOR THIS SAMPLE...: MASS ANS UNIQUE UPDATE IS POSSIBLE

            ////var internalIds = new[] { 2, 3 };

            //var friendId = 2; 

            //var filter = Builders<Personality>.Filter.Eq(x => x.Id, 1);

            //var update = Builders<Personality>.Update.Set("Friends.$[f].Name", "John");

            //var arrayFilters = new[]
            //{
            //    new BsonDocumentArrayFilterDefinition<BsonDocument>(
            //        new BsonDocument("f._id", new BsonDocument("$eq", friendId)))
            //};

            //collection.UpdateOneAsync(filter, update, new UpdateOptions { ArrayFilters = arrayFilters });

            //attempt 6 - ...WORKING FOR THIS SAMPLE...: MASS ANS UNIQUE UPDATE IS POSSIBLE

            //var internalIds = new[] { 2, 3 };

            var friendId = 2;

            var filter = Builders<Personality>.Filter.Eq(x => x.Id, 1);

            var update = Builders<Personality>.Update.Set("Friends.$[f].Name", "John");

            var arrayFilters = new[]
            {
                new BsonDocumentArrayFilterDefinition<BsonDocument>(new BsonDocument("f._id", new BsonDocument("$eq", friendId)))
            };

            var resultOfStatusChanging 
                = collection.FindOneAndUpdateAsync(filter, update, 
                    new FindOneAndUpdateOptions<Personality> { ReturnDocument = ReturnDocument.After, ArrayFilters = arrayFilters }).Result;
        }
    }
}
