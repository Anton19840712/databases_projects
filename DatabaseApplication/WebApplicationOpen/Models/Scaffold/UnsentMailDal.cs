using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("UnsentMail")]
	public class UnsentMailDal
	{
		[Key]
		public long UnsentMailId { get; set; }
		public string SendTo { get; set; }
		public string Subject { get; set; }
		public string Body { get; set; }
		public DateTime SendingFailedDate { get; set; }
		public int EmailFromId { get; set; }
		public bool? SendAtNight { get; set; }

		public virtual EmailFromDal EmailFrom { get; set; }
	}
}
