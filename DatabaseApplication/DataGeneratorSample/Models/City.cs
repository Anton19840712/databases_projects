using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataGeneratorSample.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }
        public string CityName { get; set; }
        public double CityLongitude { get; set; }
        public double CityLatitude { get; set; }
        public virtual ICollection<CityRegion> CityRegions { get; set; }
    }
}
