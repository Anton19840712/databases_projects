using HotChocolate;
using PureCodeFirst.Data.Contexts;
using PureCodeFirst.Data.Entities;

namespace PureCodeFirst.Resolvers
{
    public class MutationResolver
    {
        public Gadgets Save([Service] MyWorldDbContext context, Gadgets model)
        {

            context.Gadgets.Add(model);

            context.SaveChanges();

            return model;
        }
    }
}
