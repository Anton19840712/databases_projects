using System.ComponentModel.DataAnnotations;

namespace DataGeneratorSample.Models.Geography
{
	public class City
	{
		//[Key]
		public int CityId { get; set; }
		public string CityName { get; set; }
		public double Longitude { get; set; }
		public double Latitude { get; set; }
		//public virtual ICollection<DeliveryZone> DeliveryZones { get; set; }
	}
}
