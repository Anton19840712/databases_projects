using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataGeneratorSample.Models.Load
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ProductId { get; set; }
        public string ProductName { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        public decimal ProductPrice { get; set; }
        public int InStock { get; set; }
        public bool IsForSale { get; set; }
        public int CategoryId { get; set; }
        public IEnumerable<OrderProduct> OrderProducts { get; set; }
    }
}
