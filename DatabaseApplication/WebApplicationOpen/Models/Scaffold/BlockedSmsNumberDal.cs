using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("BlockedSmsNumber")]
	public class BlockedSmsNumberDal
	{
		public int BlockedSmsNumberId { get; set; }
		public string PhoneNumber { get; set; }
	}
}
