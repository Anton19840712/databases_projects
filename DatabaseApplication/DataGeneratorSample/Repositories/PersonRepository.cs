using System;
using System.Collections.Generic;
using Bogus;
using Person = DataGeneratorSample.Models.Person;

namespace DataGeneratorSample.Repositories
{
    public static class PersonRepository
    {
        public static List<Person> GeneratePersonModel(int maxNumberOfRows)
        {
            var idsPerson = 1;
            var personGenerator = new Faker<Person>()
                .RuleFor(o => o.PersonId, f => idsPerson++)
                .RuleFor(o => o.FirstName, f => f.Person.FirstName)
                .RuleFor(o => o.LastName, f => f.Person.LastName)
                .RuleFor(o => o.Email, f => f.Person.Email)
                .RuleFor(o => o.CartId, f => Guid.NewGuid())
                .RuleFor(o => o.JobTitle, f => f.Name.JobTitle())
                .RuleFor(o => o.PersonAge, f => f.Random.Number(16,100))
                .RuleFor(o => o.EstimatedIncome, f => f.Random.Decimal(100,1000));

            return personGenerator.Generate(maxNumberOfRows);
        }
    }
}