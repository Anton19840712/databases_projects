using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppOpenContactDatabaseFirstApproach.Models
{

	[Table("Roles")]
	public class RoleDal
	{
		[Key]
		public int RoleId { get; set; }
		public string RoleName { get; set; }
	}
}
