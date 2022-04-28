using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOpen.Models.DalModels.UserNotifications
{
	[Table("NotificationEvent")]
	public sealed class NotificationEventDal
	{
		public NotificationEventDal()
		{
			ServiceNotificationQueues = new HashSet<ServiceNotificationQueueDal>();
		}

		[Key]
		public int NotificationEventId { get; set; }
		public string Description { get; set; }

		public ICollection<ServiceNotificationQueueDal> ServiceNotificationQueues { get; set; }
	}
}
