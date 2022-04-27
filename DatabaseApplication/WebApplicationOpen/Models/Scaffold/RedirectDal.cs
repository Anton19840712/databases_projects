using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("Redirect")]
	public class RedirectDal
	{
		public long RedirectId { get; set; }
		public long? DomainId { get; set; }
		public string DomainName { get; set; }
		public string RedirectUrl { get; set; }
		public long? RedirectActionId { get; set; }

		public virtual DomainDal Domain { get; set; }
		public virtual RedirectActionDal RedirectAction { get; set; }
	}
}
