using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace MongoDemoSample
{

    //Синтаксис такой: указываешь название таблицы, указываешь айди, как правило гуид. И все.
    //Все крады строятся примерно на этом. То есть директируешь. 
    //Сама база быстрее записывает данные
    //Тебе не нужны таблицы и прочее, ты просто думаешь о рЕкордах
    //Хотим добавить поле в модель - пожалуйста, ничего не нужно делать на уровне базы - просто добавь в модель
    //Монго больше напоминает блокнот для записей

    public class Program
    {
        public static void Main(string[] args)
        {
            //IMongoQuery query = Query.NE("_id", "");

            MonDatabaseCrud db = new MonDatabaseCrud("AddressBook");

            //var result = db.LoadRecords<PersonModel>("Users");
            //var result = db.LoadRecords<ShortModel>("Users");


            //var result = db.UpsertRecords<ShortModel>("Users");

            //var person = new PersonModel
            //{
            //    FirstName = "Antonio",
            //    LastName = "Gridushko",
            //    PrimaryAddress = new AddressModel()
            //    {
            //        StreetAddress = "101 Oak Street",
            //        City = "Scranton",
            //        State = "PA",
            //        ZipCode = "18512"
            //    }
            //};

            //db.InsertRecord("Users", person);


            //UPSERT COMMAND:

            //1) Получаешь документ по определенному айди:
            //var oneRec = db.LoadRecordById<PersonModel>("Users", new Guid("87fdf2ce-852e-4d84-aac9-3e4d55be70f2"));


            //2) Меняешь определенное поле там:
            //oneRec.DateOfBirth = new DateTime(1982, 10, 31, 0,0,0,0, DateTimeKind.Utc);


            //3) Указываешь таблицу, указываешь айди модели, указываешь документ\рекорд\модель для обновления
            //db.UpsertRecords("Users", oneRec.Id, oneRec);

            //db.DeleteRecord<PersonModel>("Users", oneRec.Id);

            //db.LoadRecords<PersonModel>("Users").ForEach(PrintElements);

            //Console.WriteLine(db.LoadRecordById<PersonModel>("Users", new Guid("87fdf2ce-852e-4d84-aac9-3e4d55be70f2")));

        }


        public static void PrintElements(PersonModel x)
        {
            Console.WriteLine($"{x.Id}, {x.FirstName}, {x.LastName}");

            if (x.PrimaryAddress!=null)
            {
                Console.WriteLine(x.PrimaryAddress.City);
            }

            Console.WriteLine();
        }
    }

    [BsonIgnoreExtraElements]
    public class ShortModel
    {
        [BsonId]

        public Guid Id { get; set; }
        public string FirstName { get; set; }
    }



    public class NameModel
    {
        [BsonId] 
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class AddressModel
    {
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
    }

    public class PersonModel
    {
        [BsonId] // Like this we say mongo  database, that this field is and id of the object we are going to store
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public AddressModel PrimaryAddress { get; set; }

        [BsonElement("dob")]
        public DateTime DateOfBirth { get; set; }
    }

    public class MonDatabaseCrud
    {
        private readonly IMongoDatabase _db;

        public MonDatabaseCrud(string database)
        {
            var client = new MongoClient();

            _db = client.GetDatabase(database);
        }

        public void InsertRecord<T>(string table, T record)
        {
            var collection = _db.GetCollection<T>(table);

            collection.InsertOne(record);
        }

        public List<T> LoadRecords<T>(string table)
        {
            var collection = _db.GetCollection<T>(table);

            var result =  collection.Find(new BsonDocument()).ToList();

            return result;
        }

        public T LoadRecordById<T>(string table, Guid id)
        {
            var collection = _db.GetCollection<T>(table);

            var filter = Builders<T>.Filter.Eq("Id", id);

            return collection.Find(filter).First();
        }

        public void UpsertRecords<T>(string table, Guid id, T record)
        {
            var collection = _db.GetCollection<T>(table);

            var result = collection.ReplaceOne(
                new BsonDocument("_id", id), //need _id with prefix
                record,
                new UpdateOptions {IsUpsert = true});
        }

        public void DeleteRecord<T>(string table, Guid id)
        {
            var collection = _db.GetCollection<T>(table);

            var filter = Builders<T>.Filter.Eq("Id", id);

            collection.DeleteOne(filter);
        }
    }
}