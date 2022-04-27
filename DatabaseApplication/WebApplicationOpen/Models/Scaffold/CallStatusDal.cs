using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplicationOpen.Models.Scaffold
{
	[Table("CallStatus")]
	public sealed class CallStatusDal
	{
		public CallStatusDal()
		{
			Calls = new HashSet<CallDal>();
		}

		public long Id { get; set; }
		public string Status { get; set; }

		public ICollection<CallDal> Calls { get; set; }
	}
}
