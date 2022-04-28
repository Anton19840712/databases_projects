using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationOpen.Models.DalModels.EmailMessages;

namespace WebApplicationOpen.Models.DalModels.Common
{
	[Table("EmailFroms")]
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
