using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataGeneratorSample.Models.Load
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public int Rating { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
