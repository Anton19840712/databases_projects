using Microsoft.EntityFrameworkCore;

namespace GraphQlNorthwind.DataBaseContexts
{
    public class NorthWindContext
    {
        public NorthWindContext(DbContextOptions<NorthWindContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
    }
}