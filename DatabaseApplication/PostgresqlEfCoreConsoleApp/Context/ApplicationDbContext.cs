using Microsoft.EntityFrameworkCore;
using PostgresqlEfCoreConsoleApp.Models;

namespace PostgresqlEfCoreConsoleApp.Context
{
	public sealed class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext()
		{
			Database.EnsureCreated();
		}
		public DbSet<City> Cities { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseNpgsql("USER ID = postgres; Password=13; Server=localhost; Port=5432; Database = logistics; Integrated Security = true; Pooling = true;");
		}
	}
}
