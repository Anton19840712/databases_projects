using System.ComponentModel.DataAnnotations;

namespace OneToOne.Models
{

	// So, when we want to implement one-to-one relationship,
	//
	// 1. we need to represent BOTH TYPES in each other.
	// 2. each represented type should be virtual.
	// 3. add [Key] element to the class you understand as a key or drive instance
	// in such relationships, NOT a driven one.
	public class Author
	{
		[Key]
		public int AuthorId { get; set; }
		public string Name { get; set; }
		public virtual AuthorBiography Biography { get; set; }

		// Here is one Author has one AuthorBiography
	}
}