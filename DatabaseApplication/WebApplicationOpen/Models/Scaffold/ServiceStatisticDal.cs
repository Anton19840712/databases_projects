using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplicationOpen.Models.Scaffold
{
	[Table("ServiceStatistic")]
	public class ServiceStatisticDal
	{
		public int ServiceStatisticId { get; set; }
		public DateTime Date { get; set; }
		public string ServiceName { get; set; }
		public int Amount { get; set; }
	}
}
