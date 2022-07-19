using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataGeneratorSample.Models.Geography
{
	public class DeliveryZone
	{
		[Key]
		public int ZoneId { get; set; }
		public string ZoneName { get; set; }
		public virtual ICollection<DeliveryPoint> DeliveryPoints { get; set; }
	}
}
