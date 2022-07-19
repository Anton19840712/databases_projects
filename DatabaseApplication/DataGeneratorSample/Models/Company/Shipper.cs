using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DataGeneratorSample.Models.Load;

namespace DataGeneratorSample.Models.Company
{
    public class Shipper
    {
        [Key]
        public int ShipperId { get; set; }
        public string ShipperName { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
