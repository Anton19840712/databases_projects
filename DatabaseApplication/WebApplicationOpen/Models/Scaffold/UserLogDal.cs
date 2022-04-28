using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("UserLog")]
	public class UserLogDal
	{
		[Key]
		public long UserLogId { get; set; }
		public long LogId { get; set; }
		public long UserId { get; set; }

		public virtual LogRepositoryDal Log { get; set; }
		public virtual UserDal User { get; set; }
	}
}
