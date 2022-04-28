using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("Role")]
	public sealed class RoleDal
	{
		public RoleDal()
		{
			UserInRoles = new HashSet<UserInRoleDal>();
		}

		[Key]
		public int RoleId { get; set; }
		public string RoleName { get; set; }

		public ICollection<UserInRoleDal> UserInRoles { get; set; }
	}
}
