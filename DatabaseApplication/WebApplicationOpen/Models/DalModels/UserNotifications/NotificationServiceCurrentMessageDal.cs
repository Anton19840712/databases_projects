using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationOpen.Models.DalModels.BaseTablesForServices;
using WebApplicationOpen.Models.DalModels.Clients;

namespace WebApplicationOpen.Models.DalModels.UserNotifications
{
	[Table("NotificationServiceCurrentMessages")]
	public class NotificationServiceCurrentMessageDal
	{
		[Key]
		public long Id { get; set; }
		public long ServiceId { get; set; }
		public long ClientId { get; set; }
		public int TypeAttention { get; set; }
		public int? TypeMessage { get; set; }

		public virtual ClientDal Client { get; set; }
		public virtual ServiceDal Service { get; set; }
	}
}
