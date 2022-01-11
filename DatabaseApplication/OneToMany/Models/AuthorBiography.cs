using System;

namespace OneToMany.Models
{
    //this is dependent class, so it need foreign key in it:
    public class AuthorBiography
    {
        public int AuthorBiographyId { get; set; }
        public string Biography { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
        public string Nationality { get; set; }

        //public Author Author { get; set; }
        //we should add here `public Author Author { get; set; }`
        //- this means here, that the Author has many biographies.
        // also we need to comment
        //`public virtual ICollection<AuthorBiography> Books { get; set; }` property in the author instance.
    }
}