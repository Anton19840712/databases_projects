using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationOpen.Models.DalModels.Common;

namespace WebApplicationOpen.Models.DalModels.Billing
{
	[Table("ActionType")]
	public sealed class ActionTypeDal
	{
		public ActionTypeDal()
		{
			Statistics = new HashSet<StatisticDal>();
		}

		[Key]
		public int ActionTypeId { get; set; }
		public string ActionType1 { get; set; }

		public ICollection<StatisticDal> Statistics { get; set; }
	}
}
