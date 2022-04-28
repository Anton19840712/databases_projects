using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace WebApplicationOpen.Models.Scaffold
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
