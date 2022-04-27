using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public class NotificationEvent
	{
		public NotificationEvent()
		{
			ServiceNotificationQueues = new HashSet<ServiceNotificationQueue>();
		}

		public int NotificationEventId { get; set; }
		public string Description { get; set; }

		public virtual ICollection<ServiceNotificationQueue> ServiceNotificationQueues { get; set; }
	}
}
