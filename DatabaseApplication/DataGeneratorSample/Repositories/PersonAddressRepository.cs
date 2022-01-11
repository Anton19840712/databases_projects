using System.Collections.Generic;
using Bogus;
using DataGeneratorSample.Models;

namespace DataGeneratorSample.Repositories
{
    public static class PersonAddressRepository
    {
        public static List<PersonAddress> GenerateListOfAddresses(long maxNumberOfRows)
        {
            var idsAddress = 1;

            var addressGenerator = new Faker<PersonAddress>()
                .RuleFor(o => o.PersonAddressId, f => idsAddress++)
                .RuleFor(o => o.StreetAddress, f => f.Address.StreetAddress())
                .RuleFor(o => o.City, f => f.Address.City())
                .RuleFor(o => o.Country, f => f.Address.Country())
                .RuleFor(o => o.PersonId, f => f.Random.Long(1, maxNumberOfRows));
            return addressGenerator.Generate(2);
        }
    }
}