using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public class EmailFrom
	{
		public EmailFrom()
		{
			UnsentMails = new HashSet<UnsentMail>();
		}

		public int EmailFromId { get; set; }
		public string From { get; set; }

		public virtual ICollection<UnsentMail> UnsentMails { get; set; }
	}
}
