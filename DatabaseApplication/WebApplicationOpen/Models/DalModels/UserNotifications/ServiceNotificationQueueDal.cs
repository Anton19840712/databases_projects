using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationOpen.Models.DalModels.BaseTablesForServices;

namespace WebApplicationOpen.Models.DalModels.UserNotifications
{
	[Table("ServiceNotificationQueue")]
	public class ServiceNotificationQueueDal
	{
		[Key]
		public long ServiceNotificationQueueId { get; set; }
		public long ServiceId { get; set; }
		public int? NotificationScheduleId { get; set; }
		public int NotificationEventId { get; set; }

		public virtual NotificationEventDal NotificationEvent { get; set; }
		public virtual NotificationScheduleDal NotificationSchedule { get; set; }
		public virtual ServiceDal Service { get; set; }
	}
}
