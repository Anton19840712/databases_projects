using System.Collections.Generic;
using Bogus;
using DataGeneratorSample.Models.Load;

namespace DataGeneratorSample.Repositories
{
    public static class ProductRepository
    {
        public static List<Product> GenerateProductList(int maxNumberOfRows)
        {
            var idsProduct = 1;
            var productGenerator = new Faker<Product>()
                .RuleFor(o => o.ProductId, f => idsProduct++)
                .RuleFor(o => o.ProductName, f => f.Commerce.ProductName())
                .RuleFor(bp => bp.ProductPrice, f => f.Random.Decimal(1, 1000))
                .RuleFor(o => o.InStock, f => f.Random.Number(20,3000))
                .RuleFor(o => o.IsForSale, f => f.Random.Bool(0.8f))
                .RuleFor(bp => bp.CategoryId, f => f.Random.Number(1, 1000));

            return productGenerator.Generate(maxNumberOfRows);
        }
    }
}