using Application.Entities.Base;
using Application.Interfaces.Base;
using MongoDB.Driver;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Application.Repositories.Base
{
    public class BaseRepository<T> : IRepositoryBase<T> where T : BaseEntity
    {
        private const string DATABASE = "poc_dotnet_mongodb";
        private readonly IMongoClient _monGoClient;
        private readonly IClientSessionHandle _clientSessionHandle;
        private readonly string _collection;

        public BaseRepository(IMongoClient monGoClient, IClientSessionHandle clientSessionHandle, string collection)
        {
            (_monGoClient, _clientSessionHandle, _collection) = (monGoClient, clientSessionHandle, collection);

            if (!_monGoClient.GetDatabase(DATABASE).ListCollectionNames().ToList().Contains(collection))
                _monGoClient.GetDatabase(DATABASE).CreateCollection(collection);
        }

        protected virtual IMongoCollection<T> Collection => _monGoClient.GetDatabase(DATABASE).GetCollection<T>(_collection);

        //here we need to use as parameter _clientSessionHandle -
        //this enables to work with transactions, also we translate an object as a second parameter...:
        public async Task InsertAsync(T obj) => await Collection.InsertOneAsync(_clientSessionHandle, obj);

        public async Task UpdateAsync(T obj)
        {
            Expression<Func<T, string>> func = f => f.Id;

            //getting object as a string...: -- STRANGE...:

            var value = (string)obj
                .GetType()
                .GetProperty(
                    func.Body.ToString().Split(".")[1])?
                .GetValue(obj, null);

            //constructing filter...:
            //I am interesting in filter creation with such modifiers as: $set, $push, $inc
            var filter = Builders<T>
                .Filter
                .Eq(
                    func, //this something we get from id of the object...:
                    value //result of implicit conversion to string -> it was an object...:
                    );

            // And we use here replace one async...:
            await Collection.ReplaceOneAsync(_clientSessionHandle, filter, obj);

            //But what methods else contains collection...: and how to use them in my application...??:
            //await Collection.

//Aggregate()
//AggregateAsync()
//AggregateToCollection()
//AggregateToCollectionAsync()
//BulkWrite()
//BulkWriteAsync() //записывает пачкой
//CountDocuments()
//CountDocumentsAsync()
//DeleteMany()
//DeleteManyAsync()
//DeleteOne()
//DeleteOneAsync()
//Distinct()
//DistinctAsync()
//EstimatedDocumentCount()
//EstimatedDocumentCountAsync()
//FindAsync()
//FindOneAndDelete()
//FindOneAndDeleteAsync()
//FindOneAndReplace()
//FindOneAndReplaceAsync()
//FindOneAndUpdate()
//FindOneAndUpdateAsync()
//FindSync()
//InsertMany()
//InsertManyAsync()
//InsertOne()
//InsertOneAsync()
//MapReduce()
//MapReduceAsync()
//ReplaceOne()
//ReplaceOneAsync()
//UpdateMany()
//UpdateManyAsync()
//UpdateOne()
//UpdateOneAsync()
//Watch()
//WatchAsync()
//WithReadConcern()
//WithReadPreference()
//WithWriteConcern()



        }

        //here we need to use as parameter _clientSessionHandle - this enables to work with transactions, also we translate a filter as a second parameter...:
        public async Task DeleteAsync(string id) => await Collection.DeleteOneAsync(_clientSessionHandle, f => f.Id == id);
    }
}
