using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public sealed class SystemNotificationType
	{
		public SystemNotificationType()
		{
			SystemNotifications = new HashSet<SystemNotification>();
		}

		public int SystemNotificationTypeId { get; set; }
		public string Description { get; set; }

		public ICollection<SystemNotification> SystemNotifications { get; set; }
	}
}
