using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("UserInRole")]
	public class UserInRoleDal
	{
		[Key]
		public long UserInRolesId { get; set; }
		public long UserId { get; set; }
		public int RoleId { get; set; }

		public virtual RoleDal Role { get; set; }
		public virtual UserDal User { get; set; }
	}
}
