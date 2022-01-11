using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataGeneratorSample.Models
{
    public class Shipper
    {
        [Key]
        public int ShipperId { get; set; }
        public string ShipperName { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
