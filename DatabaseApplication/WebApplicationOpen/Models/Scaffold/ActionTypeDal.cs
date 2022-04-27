using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplicationOpen.Models.Scaffold
{
	[Table("ActionType")]
	public sealed class ActionTypeDal
	{
		public ActionTypeDal()
		{
			Statistics = new HashSet<StatisticDal>();
		}

		public int ActionTypeId { get; set; }
		public string ActionType1 { get; set; }

		public ICollection<StatisticDal> Statistics { get; set; }
	}
}
