using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public class Role
	{
		public Role()
		{
			UserInRoles = new HashSet<UserInRole>();
		}

		public int RoleId { get; set; }
		public string RoleName { get; set; }

		public virtual ICollection<UserInRole> UserInRoles { get; set; }
	}
}
