

namespace WebApplicationOpen.Models.Scaffold
{
	public class NotificationServiceCurrentMessage
	{
		public long Id { get; set; }
		public long ServiceId { get; set; }
		public long ClientId { get; set; }
		public int TypeAttention { get; set; }
		public int? TypeMessage { get; set; }

		public virtual ClientDal Client { get; set; }
		public virtual Service Service { get; set; }
	}
}
