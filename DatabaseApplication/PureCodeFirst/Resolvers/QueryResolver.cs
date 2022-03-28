using System.Collections.Generic;
using System.Linq;
using HotChocolate;
using PureCodeFirst.Data.Contexts;
using PureCodeFirst.Data.Entities;

namespace PureCodeFirst.Resolvers
{
    public class QueryResolver
    {
        public QueryResolver()
        {
            
        }

        public Gadgets FirstGadget([Service] MyWorldDbContext context)
        {
            return context.Gadgets.FirstOrDefault();
        }


        public List<Gadgets> AllGadgets([Service] MyWorldDbContext context)
        {
            return context.Gadgets.ToList();
        }

        public List<Gadgets> SearchByBrand([Service] MyWorldDbContext context, string brand)
        {
            return string.IsNullOrEmpty(brand) ? new List<Gadgets>() : context.Gadgets.Where(_=>_.Brand.ToLower() == brand.ToLower()).ToList();
        }
    }
}
