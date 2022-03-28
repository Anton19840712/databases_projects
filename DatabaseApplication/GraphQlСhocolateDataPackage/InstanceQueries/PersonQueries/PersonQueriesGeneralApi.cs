using System.Collections.Generic;
using System.Linq;
using GraphQlСhocolateDataPackage.DataBaseContexts;
using GraphQlСhocolateDataPackage.Models;
using HotChocolate;
using HotChocolate.Data;

namespace GraphQlСhocolateDataPackage.InstanceQueries.PersonQueries
{
    public class PersonQueriesGeneralApi
    {
        public Person FirstPerson([Service] PersonContext context)
        {
            return context.Persons.FirstOrDefault();
        }

        public List<Person> AllPersons([Service] PersonContext context)
        {
            return context.Persons.ToList();
        }

        public List<Person> SearchByName([Service] PersonContext context, string name)
        {
            return string.IsNullOrEmpty(name) ? new List<Person>() : context.Persons.Where(_ => _.FirstName.ToLower() == name.ToLower()).ToList();
        }

        [UseProjection]
        [UseFiltering()]
        public IQueryable<Person> SpecificPersons([Service] PersonContext context)
        {
            return context.Persons.AsQueryable();
        }
    }
}