using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DataGeneratorSample.Models.Geography;

namespace DataGeneratorSample.Models.Load
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public virtual ICollection<Country> Countries { get; set; }
        public virtual ICollection<Person.Person> Persons { get; set; }
    }
}
