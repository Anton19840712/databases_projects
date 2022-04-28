using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("SystemNotificationType")]
	public sealed class SystemNotificationTypeDal
	{
		public SystemNotificationTypeDal()
		{
			SystemNotifications = new HashSet<SystemNotificationDal>();
		}

		[Key]
		public int SystemNotificationTypeId { get; set; }
		public string Description { get; set; }

		public ICollection<SystemNotificationDal> SystemNotifications { get; set; }
	}
}
