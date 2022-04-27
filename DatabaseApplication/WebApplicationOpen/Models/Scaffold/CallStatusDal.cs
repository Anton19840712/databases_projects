using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public class CallStatusDal
	{
		public CallStatusDal()
		{
			Calls = new HashSet<CallDal>();
		}

		public long Id { get; set; }
		public string Status { get; set; }

		public virtual ICollection<CallDal> Calls { get; set; }
	}
}
