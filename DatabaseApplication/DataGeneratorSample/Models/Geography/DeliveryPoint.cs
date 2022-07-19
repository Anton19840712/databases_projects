using System.ComponentModel.DataAnnotations;

namespace DataGeneratorSample.Models.Geography
{
	public class DeliveryPoint
	{
		[Key]
		public int DeliveryPointId { get; set; }
		public string DeliveryPointName { get; set; }
		public double Longitude { get; set; }
		public double Latitude { get; set; }
	}
}
