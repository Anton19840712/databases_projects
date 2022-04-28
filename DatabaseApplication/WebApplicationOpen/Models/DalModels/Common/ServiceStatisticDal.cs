using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOpen.Models.DalModels.Common
{
	[Table("ServiceStatistics")]
	public class ServiceStatisticDal
	{
		[Key]
		public int ServiceStatisticId { get; set; }
		public DateTime Date { get; set; }
		public string ServiceName { get; set; }
		public int Amount { get; set; }
	}
}
