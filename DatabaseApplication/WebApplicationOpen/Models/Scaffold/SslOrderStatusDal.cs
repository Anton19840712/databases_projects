using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("SslOrderStatus")]
	public class SslOrderStatusDal
	{
		public int SslOrderStatusId { get; set; }
		public string Name { get; set; }
	}
}
