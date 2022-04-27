using System.ComponentModel;

namespace ConsoleAppOpenContactDatabaseFirstApproach.Models
{
	public enum UserRoleEnum
	{
		[Description("Anonymous user")] Anonymous = 0,
		[Description("Client user")] Client = 1,
		[Description("Accountant user")] Accountant = 2,
		[Description("Administrator user")] Administrator = 3,
		[Description("Manager user")] Manager = 4,
		[Description("Support user")] Support = 5,
		[Description("Marketer user")] Marketer = 6
	}
}
