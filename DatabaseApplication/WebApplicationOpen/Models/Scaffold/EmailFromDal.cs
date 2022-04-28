using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("EmailFrom")]
	public sealed class EmailFromDal
	{
		public EmailFromDal()
		{
			UnsentMails = new HashSet<UnsentMailDal>();
		}

		[Key]
		public int EmailFromId { get; set; }
		public string From { get; set; }

		public ICollection<UnsentMailDal> UnsentMails { get; set; }
	}
}
