using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplicationOpen.Models.Scaffold
{
	[Table("Role")]
	public sealed class RoleDal
	{
		public RoleDal()
		{
			UserInRoles = new HashSet<UserInRoleDal>();
		}

		public int RoleId { get; set; }
		public string RoleName { get; set; }

		public ICollection<UserInRoleDal> UserInRoles { get; set; }
	}
}
