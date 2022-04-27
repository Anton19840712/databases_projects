using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplicationOpen.Models.Scaffold
{
	[Table("EmailFrom")]
	public sealed class EmailFromDal
	{
		public EmailFromDal()
		{
			UnsentMails = new HashSet<UnsentMailDal>();
		}

		public int EmailFromId { get; set; }
		public string From { get; set; }

		public ICollection<UnsentMailDal> UnsentMails { get; set; }
	}
}
