using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOpen.Models.DalModels.Common
{
	[Table("SystemNotificationTypes")]
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
