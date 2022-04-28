using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
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
