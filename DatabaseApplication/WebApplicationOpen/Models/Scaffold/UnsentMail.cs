using System;



namespace WebApplicationOpen.Models.Scaffold
{
	public class UnsentMail
	{
		public long UnsentMailId { get; set; }
		public string SendTo { get; set; }
		public string Subject { get; set; }
		public string Body { get; set; }
		public DateTime SendingFailedDate { get; set; }
		public int EmailFromId { get; set; }
		public bool? SendAtNight { get; set; }

		public virtual EmailFrom EmailFrom { get; set; }
	}
}
