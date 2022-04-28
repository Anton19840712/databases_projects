using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOpen.Models.DalModels.Common
{
	[Table("SystemNotificationErrorLevels")]
	public sealed class SystemNotificationErrorLevelDal
	{
		public SystemNotificationErrorLevelDal()
		{
			SystemNotifications = new HashSet<SystemNotificationDal>();
		}

		[Key]
		public short SystemNotificationErrorLevelTypeId { get; set; }
		public string Description { get; set; }

		public ICollection<SystemNotificationDal> SystemNotifications { get; set; }
	}
}
