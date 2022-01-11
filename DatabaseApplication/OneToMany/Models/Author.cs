using System.Collections.Generic;

// ONE TO MANY RELATIONSHIP

namespace OneToMany.Models
{
    //Let suppose, the author has several biographies, because he is 
    // a 007 agent, for instance...
    // so...
    // here we will have one to many relationships situation
    // what should we do:
    // 1) just add `public VIRTUAL ICollection<AuthorBiography> Books { get; set; }`
    // 2) And nothing all.

    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<AuthorBiography> AuthorBiographies { get; set; } 
        // if we add collection here
        // we need to comment `public Author Author { get; set; }` property in AuthorBiography class.
        //this variant is intuitively better to understand.
        //That is way I take it here to ONE TO MANY RELATIONSHIPS SAMPLE.
    }
}

// PS: there are 4 legal conventions to provide the same result, but I take the clearest one for me.
// You can found out others variances of using such OTMR here: `https://entityframework.net/one-to-many-relationship`
