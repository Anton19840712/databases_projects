using System;



namespace WebApplicationOpen.Models.Scaffold
{
	public class SystemNotification
	{
		public long SystemNotificationId { get; set; }
		public int SystemNotificationTypeId { get; set; }
		public short SystemNotificationErrorLevelTypeId { get; set; }
		public long? UserId { get; set; }
		public string Description { get; set; }
		public DateTime CreateDate { get; set; }
		public DateTime? UpdateDate { get; set; }
		public bool IsProcessed { get; set; }

		public virtual SystemNotificationErrorLevel SystemNotificationErrorLevelType { get; set; }
		public virtual SystemNotificationType SystemNotificationType { get; set; }
	}
}
