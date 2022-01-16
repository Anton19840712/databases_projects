using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Net;
using System.Threading.Channels;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

//https://www.niceonecode.com/Blog/64/Left-Join-in-MongoDB-using-the-CSharp-driver-and-LINQ

namespace MongoSamp2
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var monGoRepository = new MonGoRepository("test"); //point the database we are going to connect


            //↓ updating by filtering studies...:15 1 2022
            //var rew = await monGoRepository.UpdateManyByArrayOfIdFiltering("persons");
            //↑ updating by filtering studies...:15 1 2022


            //↓ updating by filtering studies...:15 1 2022
            //var rew = await monGoRepository.UpdateManyFiltering("persons");
            //↑ updating by filtering studies...:15 1 2022


            //↓ updating by filtering studies...:15 1 2022
            //var rew =await monGoRepository.UpdateElemMatchFiltering("persons");
            //↑ updating by filtering studies...:15 1 2022


            //↓ updating by filtering studies...:15 1 2022
            //var collection = await monGoRepository.UpdateOneByFiltering("members");
            //↑ updating by filtering studies...:15 1 2022


            //↓ filtering studies...:15 1 2022
            //var collection = monGoRepository.FilterCollectionByTextField("cities");
            //collection.ForEach(Console.WriteLine);
            //↑ filtering studies...:15 1 2022


            //case sensitive on "cities" and name of fields also.
            //var result = monGoRepository.ListAllRecords<Cities>("cities");





            //var result = monGoRepository.ListAllRecords<CountriesDto>("countries");

            //var countriesWithCitiesList = monGoRepository.JoinTables("countries");


            //UPSERT COMMAND:


            //1) Получаешь документ по определенному айди:
            //var oneRec = monGoRepository.FindRecordById<Cities>("cities", ObjectId.Parse("61d0c7732bc77ffed8a30dae"));


            //2) Меняешь определенное поле там:
            //oneRec.City = "Brest";


            //3) Указываешь таблицу, указываешь айди модели, указываешь документ\рекорд\модель для обновления
            //monGoRepository.UpdateByInsertRecords("cities", oneRec.Id, oneRec);




        }
    }

    public class Person
    {
        public int Id { get; set; }

        public Friend[] Friends { get; set; }
    }

    public class Friend
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }


    public class Member
    {
        public int Id { get; set; }
        public int[] Friends { get; set; }
    }


    [BsonIgnoreExtraElements]
    public class CountriesDto
    { 
        public ObjectId Id { get; set; }
        public string Country { get; set; }
        public int CountryNumber { get; set; }
    }

    public class Countries
    {
        [BsonId] // Оно мало что дает, может сгенерировать просто нули для свойства Guid
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


    public class CitiesDto
    {
        public ObjectId Id { get; set; }
        public string City { get; set; }
        public int CountryId { get; set; }
    }

    public class CountriesCities : Countries
    {
        public IEnumerable<Cities> CountriesWithTheirCities { get; set; }
    }


    
}
