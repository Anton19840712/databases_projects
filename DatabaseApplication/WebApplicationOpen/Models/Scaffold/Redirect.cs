

namespace WebApplicationOpen.Models.Scaffold
{
	public class Redirect
	{
		public long RedirectId { get; set; }
		public long? DomainId { get; set; }
		public string DomainName { get; set; }
		public string RedirectUrl { get; set; }
		public long? RedirectActionId { get; set; }

		public virtual Domain Domain { get; set; }
		public virtual RedirectAction RedirectAction { get; set; }
	}
}
