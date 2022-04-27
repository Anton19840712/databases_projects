using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppOpenContactDatabaseFirstApproach.Models
{
	[Table("UserInRoles")]
	public class UserInRoleDal
	{
		[Key]
		public long UserInRolesId { get; set; }
		public long UserId { get; set; }
		public int RoleId { get; set; }
	}
}
