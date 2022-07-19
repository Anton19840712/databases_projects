using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataGeneratorSample.Models.Load
{
    public class OrderProduct
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long OrderProductId { get; set; }

        [ForeignKey("Order")]
        public long OrderId { get; set; }
        public Order Order { get; set; }

        [ForeignKey("Product")]
        public long ProductId { get; set; }
        public Product Product { get; set; }
    }
}