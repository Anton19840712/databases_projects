using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public class RedirectAction
	{
		public RedirectAction()
		{
			Redirects = new HashSet<Redirect>();
		}

		public long RedirectActionId { get; set; }
		public string ActionName { get; set; }

		public virtual ICollection<Redirect> Redirects { get; set; }
	}
}
