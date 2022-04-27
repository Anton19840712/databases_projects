using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// MANY TO MANY RELATIONSHIP

namespace ManyToMany.Models
{
	//1. need join table here
	//...let we store it under the Author class to have better visual navigation:
	//2. used `virtual` word
	//3. virtual ICollection properties in both tables
	//4. used join table in the middle between two main instances. No drive and driven instances.
	//5. each table contains ICollection property with middle/united left and right table instances

	public class Author
	{
		public int AuthorId { get; set; }
		public string Name { get; set; }
		public virtual ICollection<AuthorAndBiography> AuthorAndBiographies { get; set; }
	}

	public class AuthorAndBiography
	{
		[Key, Column(Order = 1)]
		public int AuthorId { get; set; }

		[Key, Column(Order = 2)]
		public int AuthorBiographyId { get; set; }

		public Author Author { get; set; } //Class Author
		public AuthorBiography AuthorBiography { get; set; } //Class AuthorBiography
	}
}
