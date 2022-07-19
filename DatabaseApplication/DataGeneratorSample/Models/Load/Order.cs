using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataGeneratorSample.Models.Load
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long OrderId { get; set; }
        public DateTime Created { get; set; }
        [Column(TypeName = "decimal(5,2)")]
        public decimal OrderValue { get; set; }
        public bool IsShipped { get; set; }
        public IEnumerable<OrderProduct> OrderProducts { get; set; }
        [ForeignKey("Person")]
        public long PersonId { get; set; }
        public Person.Person CurrentPerson { get; set; }
    }
}
