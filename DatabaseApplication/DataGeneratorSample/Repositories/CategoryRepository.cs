using System.Collections.Generic;
using Bogus;
using DataGeneratorSample.Models;

namespace DataGeneratorSample.Repositories
{
    
    public static class CategoryRepository
    {
        static readonly List<string> CategoriesList = new List<string> { "A", "B", "C", "D", "E", "F" };
        public static List<Category> GenerateCategoryList(int maxNumberOfRows)
        {
            var idsCategory = 1;
            var productGenerator = new Faker<Category>()
                .RuleFor(o => o.CategoryId, f => idsCategory++)
                .RuleFor(o => o.CategoryName, f => f.PickRandom(CategoriesList))
                .RuleFor(bp => bp.Rating, f => f.Random.Number(1, 100));

            return productGenerator.Generate(maxNumberOfRows);
        }
    }
}