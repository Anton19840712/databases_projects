using System.ComponentModel.DataAnnotations.Schema;

namespace PostgresqlEfCoreConsoleApp.Models
{
	[Table("cities")]
	public class City
	{
		//[Key]
		[Column("cityid")]
		public int CityId { get; set; }

		[Column("cityname")]
		public string CityName { get; set; }

		[Column("longitude")]
		public double Longitude { get; set; }

		[Column("latitude")]
		public double Latitude { get; set; }

		//public virtual ICollection<DeliveryZone> DeliveryZones { get; set; }
	}
}
