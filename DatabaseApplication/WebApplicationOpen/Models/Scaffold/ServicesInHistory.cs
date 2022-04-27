

namespace WebApplicationOpen.Models.Scaffold
{
	public class ServicesInHistory
	{
		public long ServicesInHistoryId { get; set; }
		public long ServiceId { get; set; }
		public long ServiceHistoryId { get; set; }

		public virtual Service Service { get; set; }
		public virtual ServiceHistory ServiceHistory { get; set; }
	}
}
