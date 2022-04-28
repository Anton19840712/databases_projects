using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOpen.Models.DalModels.Domains
{
	[Table("RedirectActions")]
	public sealed class RedirectActionDal
	{
		public RedirectActionDal()
		{
			Redirects = new HashSet<RedirectDal>();
		}

		[Key]
		public long RedirectActionId { get; set; }
		public string ActionName { get; set; }

		public ICollection<RedirectDal> Redirects { get; set; }
	}
}
