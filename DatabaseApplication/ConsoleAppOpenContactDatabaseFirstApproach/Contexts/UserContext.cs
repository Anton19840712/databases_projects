using ConsoleAppOpenContactDatabaseFirstApproach.Models;
using System.Data.Entity;

namespace ConsoleAppOpenContactDatabaseFirstApproach.Contexts
{
	public class UserContext : DbContext
	{
		public UserContext() : base("DbConnectionString")
		{

		}
		public DbSet<UserDal> Users { get; set; }
		public DbSet<BackendUserDal> BackendUsers { get; set; }
		public DbSet<UserInRoleDal> UserInRoles { get; set; }
		public DbSet<RoleDal> Roles { get; set; }
	}
}
