using Microsoft.EntityFrameworkCore;
using PureCodeFirst.Data.Entities;

namespace PureCodeFirst.Data.Contexts
{
    public class MyWorldDbContext : DbContext
    {
        public MyWorldDbContext(DbContextOptions<MyWorldDbContext> options) : base(options) { }

        public DbSet<Gadgets> Gadgets { get; set; }
    }
}