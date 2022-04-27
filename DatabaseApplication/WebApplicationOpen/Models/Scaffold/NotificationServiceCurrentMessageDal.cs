using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("NotificationServiceCurrentMessage")]
	public class NotificationServiceCurrentMessageDal
	{
		public long Id { get; set; }
		public long ServiceId { get; set; }
		public long ClientId { get; set; }
		public int TypeAttention { get; set; }
		public int? TypeMessage { get; set; }

		public virtual ClientDal Client { get; set; }
		public virtual ServiceDal Service { get; set; }
	}
}
