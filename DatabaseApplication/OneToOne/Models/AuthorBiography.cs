using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace OneToOne.Models
{
    //this is dependent class, so it need foreign key in it:
    public class AuthorBiography
    {
        [ForeignKey("Author")] //Look at this: You need to add here DataAnnotations Schema to the Id property of author biography
        //In this case, the AuthorBiography is depending on Author, so the AuthorBiographyId property is a primary as well as a foreign key.
        public int AuthorBiographyId { get; set; }
        public string Biography { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
        public string Nationality { get; set; }
        public virtual Author Author { get; set; } //Take a look here: here is One to One relationship:
                                                   //Means one Author has one AuthorBiography, 
        
        //but looks like one AuthorBiography has one Author.
    }
}