

namespace WebApplicationOpen.Models.Scaffold
{
	public class UserInRole
	{
		public long UserInRolesId { get; set; }
		public long UserId { get; set; }
		public int RoleId { get; set; }

		public virtual Role Role { get; set; }
		public virtual User User { get; set; }
	}
}
