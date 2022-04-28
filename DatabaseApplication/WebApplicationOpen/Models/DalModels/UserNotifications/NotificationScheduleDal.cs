using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationOpen.Models.DalModels.BaseTablesForServices;

namespace WebApplicationOpen.Models.DalModels.UserNotifications
{
	[Table("NotificationSchedules")]
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
