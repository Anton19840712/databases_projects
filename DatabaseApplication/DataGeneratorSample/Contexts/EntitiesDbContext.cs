using DataGeneratorSample.Models.Geography;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace DataGeneratorSample.Contexts
{
	public sealed class EntitiesDbContext : DbContext
	{
		//protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		//{
		//	optionsBuilder.EnableSensitiveDataLogging();
		//	//optionsBuilder.UseSqlServer(
		//	//	"Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog = EntitiesDatabase;Integrated Security =True;Connect Timeout = 30;" +
		//	//	"Encrypt = False;TrustServerCertificate = False;ApplicationIntent = ReadWrite;MultiSubnetFailover = False");
		//	optionsBuilder.UseNpgsql("USER ID = postgres; Password=13; Server=localhost; Port=5432; Database = logistics; Integrated Security = true; Pooling = true;");
		//}


		////public DbSet<Person.Person> Persons { get; set; }
		////public DbSet<PersonAddress> PersonAddresses { get; set; }
		////public DbSet<Vehicle> Vehicles { get; set; }
		////public DbSet<Category> Categories { get; set; }
		////public DbSet<Order> Orders { get; set; }
		////public DbSet<OrderProduct> OrderProducts { get; set; }
		////public DbSet<Product> Products { get; set; }
		//public DbSet<City> Cities { get; set; }

		//protected override void OnModelCreating(ModelBuilder modelBuilder)
		//{
		//	base.OnModelCreating(modelBuilder);
		//	modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
		//}

		public EntitiesDbContext()
		{
			Database.EnsureCreated();
		}

		public DbSet<City> Cities { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseNpgsql(
				"USER ID = postgres; Password=13; Server=localhost; Port=5432; Database = logistics; Integrated Security = true; Pooling = true;");
		}
	}

}
