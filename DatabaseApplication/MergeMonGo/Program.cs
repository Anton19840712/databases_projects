using Mongo.DAL.Models;
using MongoDB.Driver;
using System;
using System.Linq;
using System.Text.Json;
using Mongo.DAL.UnwindModel;
using MongoDB.Bson;
//Попробуй с конкретных примеров в документации...:
//db.salaries.insertMany([
//{ "_id" : 1, employee: "Ant", dept: "A", salary: 100000, fiscal_year: 2017 },
//{ "_id" : 2, employee: "Bee", dept: "A", salary: 120000, fiscal_year: 2017 },
//{ "_id" : 3, employee: "Cat", dept: "Z", salary: 115000, fiscal_year: 2017 },
//{ "_id" : 4, employee: "Ant", dept: "A", salary: 115000, fiscal_year: 2018 },
//{ "_id" : 5, employee: "Bee", dept: "Z", salary: 145000, fiscal_year: 2018 },
//{ "_id" : 6, employee: "Cat", dept: "Z", salary: 135000, fiscal_year: 2018 },
//{ "_id" : 7, employee: "Gecko", dept: "A", salary: 100000, fiscal_year: 2018 },
//{ "_id" : 8, employee: "Ant", dept: "A", salary: 125000, fiscal_year: 2019 },
//{ "_id" : 9, employee: "Bee", dept: "Z", salary: 160000, fiscal_year: 2019 },
//{ "_id" : 10, employee: "Cat", dept: "Z", salary: 150000, fiscal_year: 2019 }
//])


namespace MergeMonGo
{
    class Program
    {
        static void Main(string[] args)
        {
            //The $merge operator must be the last stage in the pipeline.
            //Creates a new collection if the output collection does not already exist.


            var client = new MongoClient();

            var monGoRepository = client.GetDatabase("test");

            //SALARIES...:
            //salaries collection...:
            var mongoCollectionSalaries = monGoRepository.GetCollection<Salaries>("salaries");

            //salaries count...:
            var mongoCollectionSalariesCount = mongoCollectionSalaries.CountDocuments(_=>true);

            //salaries filters...:

            var filterDefinitionSalariesById = Builders<Salaries>.Filter.Eq("Id", 3);

            var filterDefinitionSalariesByEmployee = Builders<Salaries>.Filter.Eq(a => a.Employee, "Cat");

            var singleSalaryById = mongoCollectionSalaries.Find(filterDefinitionSalariesById).First();

            var singleSalaryByEmployee = mongoCollectionSalaries.Find(filterDefinitionSalariesByEmployee).First();


            
            //PERSONS...:
            //persons collection...:
            var mongoCollectionPersons = monGoRepository.GetCollection<Person>("persons");

            //persons count...:
            var mongoCollectionPersonsCount = monGoRepository.GetCollection<Person>("persons").CountDocuments(_ => true);

            //persons filters...:

            var filterDefinitionPersonById = Builders<Person>.Filter.Eq("Id", 2);

            var filterDefinitionPersonByEmployee = Builders<Person>.Filter.Gt(a => a.Age, 33);

            var singlePersonById = mongoCollectionPersons.Find(filterDefinitionPersonById).First();

            var listPersonByAgeMoreThane34 = mongoCollectionPersons.Find(filterDefinitionPersonByEmployee).ToList();



            var mergeOptions = new MergeStageOptions<Person>
            {
                OnFieldNames = new[] { "_id" },
                WhenMatched = MergeStageWhenMatched.Merge, //so, you replace from salaries? all ids, that are in persons.
                WhenNotMatched = MergeStageWhenNotMatched.Insert
            };

            var items = mongoCollectionSalaries.Aggregate()
                .Match(filterDefinitionSalariesById)
                //when you merge, you insert in persons model from salaries
                .Merge(mongoCollectionPersons, mergeOptions).ToListAsync().Result;

            //var jsonString = JsonSerializer.Serialize(items);

            //Console.WriteLine(jsonString);

            //db.getSiblingDB("zoo").salaries.aggregate( [
            //{ $group: { _id: { fiscal_year: "$fiscal_year", dept: "$dept" }, salaries: { $sum: "$salary" } } },
            //{ $merge: { into: { db: "reporting", coll: "budgets" }, on: "_id",  whenMatched: "replace", whenNotMatched: "insert" } }
            //] )

            //var items = mongoCollectionPersonalities.Aggregate()
            //    .Match(filterDefinition)
            //    .Unwind<Personality, PersonalityUnwind>(r => r.Friends).ToListAsync().Result;
            // System.AggregateException: 'Element 'Friends' does not match any field or property of class Mongo.DAL.Models.Salaries.'
            // You try to merge 

            //var jsonString = JsonSerializer.Serialize(items);

            //Console.WriteLine(jsonString);
        }
    }
}
