using System.Collections.Generic;
using System.Threading.Tasks;
using Mongo.DAL.Models;

//https://www.niceonecode.com/Blog/64/Left-Join-in-MongoDB-using-the-CSharp-driver-and-LINQ

namespace MongoSamp2
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var monGoRepository = new MonGoRepository("test"); //point the database we are going to connect
            
            //↓ updating by filtering studies...:15 1 2022
            var rew = await monGoRepository.UpdateManyInMany("persons");
            //↑ updating by filtering studies...:15 1 2022

            //var collection = monGoRepository.ListAllRecords("cities");

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
            //var collection = await monGoRepository.FilterCollectionByTextField("cities");
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

    
    public class CountriesCities : Countries
    {
        public IEnumerable<Cities> CountriesWithTheirCities { get; set; }
    }


    
}
