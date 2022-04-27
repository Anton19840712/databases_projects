using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppOpenContactDatabaseFirstApproach.Models
{
	[Table("BackEndUsers")]
	public class BackendUserDal
	{
		[Key]
		public long BackendUserId { get; set; }
		public long UserId { get; set; }
		public string FullName { get; set; }

		[Required]
		public virtual UserDal User { get; set; }
	}
}