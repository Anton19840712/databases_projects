using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("SystemNotification")]
	public class SystemNotificationDal
	{
		[Key]
		public long SystemNotificationId { get; set; }
		public int SystemNotificationTypeId { get; set; }
		public short SystemNotificationErrorLevelTypeId { get; set; }
		public long? UserId { get; set; }
		public string Description { get; set; }
		public DateTime CreateDate { get; set; }
		public DateTime? UpdateDate { get; set; }
		public bool IsProcessed { get; set; }

		public virtual SystemNotificationErrorLevelDal SystemNotificationErrorLevelType { get; set; }
		public virtual SystemNotificationTypeDal SystemNotificationType { get; set; }
	}
}
