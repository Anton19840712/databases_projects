using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("SystemNotificationErrorLevel")]
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
