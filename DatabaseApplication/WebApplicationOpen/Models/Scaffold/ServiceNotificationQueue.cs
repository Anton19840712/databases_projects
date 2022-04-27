

namespace WebApplicationOpen.Models.Scaffold
{
	public class ServiceNotificationQueue
	{
		public long ServiceNotificationQueueId { get; set; }
		public long ServiceId { get; set; }
		public int? NotificationScheduleId { get; set; }
		public int NotificationEventId { get; set; }

		public virtual NotificationEvent NotificationEvent { get; set; }
		public virtual NotificationSchedule NotificationSchedule { get; set; }
		public virtual Service Service { get; set; }
	}
}
