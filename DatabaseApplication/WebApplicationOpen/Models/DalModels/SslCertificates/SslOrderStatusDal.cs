using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOpen.Models.DalModels.SslCertificates
{
	[Table("SslOrderStatuses")]
	public class SslOrderStatusDal
	{
		[Key]
		public int SslOrderStatusId { get; set; }
		public string Name { get; set; }
	}
}
