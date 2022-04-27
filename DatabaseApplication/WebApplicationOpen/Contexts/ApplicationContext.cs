using Microsoft.EntityFrameworkCore;
using WebApplicationOpen.Models;
using WebApplicationOpen.Models.Scaffold;

namespace WebApplicationOpen.Contexts
{
	public class ApplicationContext: DbContext
	{
		public ApplicationContext(DbContextOptions<ApplicationContext> options):base(options)
		{
		}
		public DbSet<Person> Persons { get; set; }
		public DbSet<Models.Scaffold.UserDal> Users{ get; set; }
		public DbSet<Models.BackEndUser> BackendUsers { get; set; }
	}
}
