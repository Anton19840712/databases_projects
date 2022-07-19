using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataGeneratorSample.Models.Geography
{
	public class Country
	{
		[Key]
		public int CountryId { get; set; }
		public string CountryName { get; set; }
		public string CountryCode { get; set; }
		public virtual ICollection<City> Cities { get; set; }
	}
}
