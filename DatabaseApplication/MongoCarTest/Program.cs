using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoCarTest
{
	class Program
	{
		static void Main(string[] args)
		{
			var monGoRepository = new MonGoRepository("skishift,");

			var collection = monGoRepository.ListAllCars("car");

			foreach (var item in collection)
			{

				Console.WriteLine(item.Brand);
			}

			Console.ReadKey();
		}
	}
	public class MonGoRepository
	{
		private readonly IMongoDatabase _monGoRepository;

		#region Constructor
		public MonGoRepository(string database)
		{
			var client = new MongoClient();
			_monGoRepository = client.GetDatabase(database);
		}
		#endregion

		public T FindRecordById<T>(string table, ObjectId id)
		{
			var collection = _monGoRepository.GetCollection<T>(table);

			var filter = Builders<T>.Filter.Eq("Id", id);

			return collection.Find(filter).First();
		}

		public void InsertModel<T>(string table, T record)
		{
			var collection = _monGoRepository.GetCollection<T>(table);

			collection.InsertOne(record);
		}

		public List<Car> ListAllCars(string table)
		{
			IMongoCollection<Car> collection = _monGoRepository.GetCollection<Car>(table);

			return collection.Find(new BsonDocument()).ToList();
		}
	}



	public class Car
	{
		public string Id { get; set; }
		public string CreatedOn { get; set; }
		public string ClientId { get; set; }
		public string TypeCar { get; set; }
		public string Color { get; set; }
		public string Number { get; set; }
		public bool IsSelected { get; set; }
		public string IsChecked { get; set; }
		public string Model { get; set; }
		public string Year { get; set; }
		public string Brand { get; set; }
	}
}
