

namespace WebApplicationOpen.Models.Scaffold
{
	public class UserLog
	{
		public long UserLogId { get; set; }
		public long LogId { get; set; }
		public long UserId { get; set; }

		public virtual LogRepository Log { get; set; }
		public virtual User User { get; set; }
	}
}
