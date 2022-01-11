using System.ComponentModel.DataAnnotations;

namespace DataGeneratorSample.Models
{
    public class CityRegionLocation
    {
        [Key]
        public int CityRegionLocationId { get; set; }
        public string StreetName { get; set; }
    }
}
