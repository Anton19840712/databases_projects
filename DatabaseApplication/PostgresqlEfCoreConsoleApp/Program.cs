using PostgresqlEfCoreConsoleApp.Context;
using PostgresqlEfCoreConsoleApp.Repositories;

namespace PostgresqlEfCoreConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			using ApplicationDbContext db = new ApplicationDbContext();

			var cities = CityRepository.GenerateListOfCities(1000);

			db.Cities.AddRange(cities);

			db.SaveChanges();
		}
	}
}