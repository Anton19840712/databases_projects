using Bogus;
using DataGeneratorSample.Models.Geography;
using System.Collections.Generic;

namespace DataGeneratorSample.Repositories
{
	public class CityRepository
	{
		public static IEnumerable<City> GenerateListOfCities(int maxNumberOfRows)
		{
			var idsCity = 1;
			var vehicleGenerator = new Faker<City>()
				.RuleFor(c => c.CityId, f => idsCity++)
				.RuleFor(c => c.CityName, f => f.Address.City())
				.RuleFor(c => c.Latitude, f => f.Address.Latitude())
				.RuleFor(c => c.Longitude, f => f.Address.Longitude())
				;

			return vehicleGenerator.Generate(maxNumberOfRows);
		}
	}
}