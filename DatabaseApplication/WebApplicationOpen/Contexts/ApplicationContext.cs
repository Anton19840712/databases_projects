using Microsoft.EntityFrameworkCore;
using WebApplicationOpen.Models;
using WebApplicationOpen.Models.DalModels.Users;

namespace WebApplicationOpen.Contexts
{
	public class ApplicationContext: DbContext
	{
		public ApplicationContext(DbContextOptions<ApplicationContext> options):base(options)
		{
		}
		public DbSet<Person> Persons { get; set; }
		public DbSet<UserDal> Users{ get; set; }
		//public DbSet<User> Users { get; set; }
		public DbSet<Models.BackEndUser> BackendUsers { get; set; }
	}
}
