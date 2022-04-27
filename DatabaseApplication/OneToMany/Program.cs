using OneToMany.Models;
using System.Collections.Generic;
using System.Linq;

namespace OneToMany
{
	class Program
	{
		static void Main(string[] args)
		{
			using var context = new AuthorBiographiesContext();
			Author author = new Author()
			{
				Name = "Mark",

				AuthorBiographies = new List<AuthorBiography>
				{
					new AuthorBiography() {Biography = "RealBiography"},
					new AuthorBiography() {Biography = "FakeBiography"}
				}
			};

			context.Authors.Add(author);
			context.SaveChanges();

			var authorData = context.Authors.ToList();
			var books = context.AuthorBiographies.ToList();
		}
	}
}
