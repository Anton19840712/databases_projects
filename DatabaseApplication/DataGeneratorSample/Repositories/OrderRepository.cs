using System.Collections.Generic;
using Bogus;
using DataGeneratorSample.Models;

namespace DataGeneratorSample.Repositories
{
    public static class OrderRepository
    {
        public static List<Order> GenerateOrderList(int maxNumberOfRows)
        {
            var idsOrder = 1;
            var orderGenerator = new Faker<Order>()
                .RuleFor(o => o.OrderId, f => idsOrder++)
                .RuleFor(o => o.OrderValue, f => f.Random.Decimal(1, 1000))
                .RuleFor(bp => bp.IsShipped, f => f.Random.Bool(0.1f))
                .RuleFor(o => o.Created, f => f.Date.Past())
                .RuleFor(o => o.PersonId, f => f.Random.Number(1, maxNumberOfRows));

            return orderGenerator.Generate(maxNumberOfRows);
        }
    }
}