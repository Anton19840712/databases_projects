using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataGeneratorSample.Models
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public virtual ICollection<Country> Countries { get; set; }
        public virtual ICollection<Person> Persons { get; set; }
    }
}
