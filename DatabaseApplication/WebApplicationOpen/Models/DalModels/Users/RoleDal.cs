using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOpen.Models.DalModels.Users
{
	[Table("Roles")]
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
