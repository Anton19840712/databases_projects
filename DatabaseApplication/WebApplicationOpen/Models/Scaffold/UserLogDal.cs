using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("UserLog")]
	public class UserLogDal
	{
		public long UserLogId { get; set; }
		public long LogId { get; set; }
		public long UserId { get; set; }

		public virtual LogRepository Log { get; set; }
		public virtual UserDal User { get; set; }
	}
}
