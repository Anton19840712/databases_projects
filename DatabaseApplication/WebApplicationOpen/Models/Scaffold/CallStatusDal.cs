using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("CallStatus")]
	public sealed class CallStatusDal
	{
		public CallStatusDal()
		{
			Calls = new HashSet<CallDal>();
		}

		[Key]
		public long Id { get; set; }
		public string Status { get; set; }

		public ICollection<CallDal> Calls { get; set; }
	}
}
