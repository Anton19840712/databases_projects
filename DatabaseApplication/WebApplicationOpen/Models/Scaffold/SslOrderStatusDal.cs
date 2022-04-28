using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("SslOrderStatus")]
	public class SslOrderStatusDal
	{
		[Key]
		public int SslOrderStatusId { get; set; }
		public string Name { get; set; }
	}
}
