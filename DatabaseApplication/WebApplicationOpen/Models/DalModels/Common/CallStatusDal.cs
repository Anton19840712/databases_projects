using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOpen.Models.DalModels.Common
{
	[Table("CallStatuses")]
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
