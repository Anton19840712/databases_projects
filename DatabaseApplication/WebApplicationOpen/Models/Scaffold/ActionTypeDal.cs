using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public sealed class ActionTypeDal
	{
		public ActionTypeDal()
		{
			Statistics = new HashSet<Statistic>();
		}

		public int ActionTypeId { get; set; }
		public string ActionType1 { get; set; }

		public ICollection<Statistic> Statistics { get; set; }
	}
}
