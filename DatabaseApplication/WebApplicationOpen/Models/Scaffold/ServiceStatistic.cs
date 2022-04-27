using System;



namespace WebApplicationOpen.Models.Scaffold
{
	public class ServiceStatistic
	{
		public int ServiceStatisticId { get; set; }
		public DateTime Date { get; set; }
		public string ServiceName { get; set; }
		public int Amount { get; set; }
	}
}
