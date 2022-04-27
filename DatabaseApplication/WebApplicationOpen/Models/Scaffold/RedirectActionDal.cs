using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplicationOpen.Models.Scaffold
{
	[Table("RedirectAction")]
	public sealed class RedirectActionDal
	{
		public RedirectActionDal()
		{
			Redirects = new HashSet<RedirectDal>();
		}

		public long RedirectActionId { get; set; }
		public string ActionName { get; set; }

		public ICollection<RedirectDal> Redirects { get; set; }
	}
}
