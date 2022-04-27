using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplicationOpen.Models.Scaffold
{
	[Table("NotificationSchedule")]
	public sealed class NotificationScheduleDal
	{
		public NotificationScheduleDal()
		{
			ServiceNotificationQueues = new HashSet<ServiceNotificationQueueDal>();
		}

		public int NotificationScheduleId { get; set; }
		public int NotifyDaysBeforeTerm { get; set; }
		public int ServiceTypeId { get; set; }

		public ServiceTypeDal ServiceType { get; set; }
		public ICollection<ServiceNotificationQueueDal> ServiceNotificationQueues { get; set; }
	}
}
