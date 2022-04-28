using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
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
