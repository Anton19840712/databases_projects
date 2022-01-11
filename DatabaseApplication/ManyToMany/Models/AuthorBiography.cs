using System;
using System.Collections.Generic;

namespace ManyToMany.Models
{
    //this is dependent class, so it need foreign key in it:
    public class AuthorBiography
    {
        public int AuthorBiographyId { get; set; }
        public string Biography { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
        public string Nationality { get; set; }
        public virtual ICollection<AuthorAndBiography> AuthorAndBiographies { get; set; }
    }
}