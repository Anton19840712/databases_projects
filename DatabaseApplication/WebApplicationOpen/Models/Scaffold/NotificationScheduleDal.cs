using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("NotificationSchedule")]
	public sealed class NotificationScheduleDal
	{
		public NotificationScheduleDal()
		{
			ServiceNotificationQueues = new HashSet<ServiceNotificationQueueDal>();
		}

		[Key]
		public int NotificationScheduleId { get; set; }
		public int NotifyDaysBeforeTerm { get; set; }
		public int ServiceTypeId { get; set; }

		public ServiceTypeDal ServiceType { get; set; }
		public ICollection<ServiceNotificationQueueDal> ServiceNotificationQueues { get; set; }
	}
}
