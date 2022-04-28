using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOpen.Models.DalModels.SmsMessages
{
	[Table("BlockedSmsNumbers")]
	public class BlockedSmsNumberDal
	{
		[Key]
		public int BlockedSmsNumberId { get; set; }
		public string PhoneNumber { get; set; }
	}
}
