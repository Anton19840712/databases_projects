using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public class NotificationSchedule
	{
		public NotificationSchedule()
		{
			ServiceNotificationQueues = new HashSet<ServiceNotificationQueue>();
		}

		public int NotificationScheduleId { get; set; }
		public int NotifyDaysBeforeTerm { get; set; }
		public int ServiceTypeId { get; set; }

		public virtual ServiceType ServiceType { get; set; }
		public virtual ICollection<ServiceNotificationQueue> ServiceNotificationQueues { get; set; }
	}
}
