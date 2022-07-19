using System.Collections.Generic;
using Bogus;
using DataGeneratorSample.Models.Load;

namespace DataGeneratorSample.Repositories
{
    public static class OrderProductRepository
    {
        public static List<OrderProduct> GenerateOrderProductList(int maxNumberOfRows)
        {
            var idsOrderProduct = 1;
            var orderProductGenerator = new Faker<OrderProduct>()
                .RuleFor(o => o.OrderProductId, f => idsOrderProduct++)
                .RuleFor(o => o.OrderId, f => f.Random.Long(1, maxNumberOfRows))
                .RuleFor(o => o.ProductId, f => f.Random.Long(1, maxNumberOfRows));

            return orderProductGenerator.Generate(maxNumberOfRows);
        }
    }
}