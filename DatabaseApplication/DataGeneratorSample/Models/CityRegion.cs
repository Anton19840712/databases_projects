using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataGeneratorSample.Models
{
    public class CityRegion
    {
        [Key]
        public int CityRegionId { get; set; }
        public string CityRegionName { get; set; }
        public virtual ICollection<CityRegionLocation> CityRegionLocations { get; set; }
    }
}
