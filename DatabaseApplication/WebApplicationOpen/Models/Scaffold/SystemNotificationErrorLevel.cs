using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public sealed class SystemNotificationErrorLevel
	{
		public SystemNotificationErrorLevel()
		{
			SystemNotifications = new HashSet<SystemNotification>();
		}

		public short SystemNotificationErrorLevelTypeId { get; set; }
		public string Description { get; set; }

		public ICollection<SystemNotification> SystemNotifications { get; set; }
	}
}
