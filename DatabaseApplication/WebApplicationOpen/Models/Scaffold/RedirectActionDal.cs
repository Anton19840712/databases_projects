using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("RedirectAction")]
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
