using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("BlockedSmsNumber")]
	public class BlockedSmsNumberDal
	{
		[Key]
		public int BlockedSmsNumberId { get; set; }
		public string PhoneNumber { get; set; }
	}
}
