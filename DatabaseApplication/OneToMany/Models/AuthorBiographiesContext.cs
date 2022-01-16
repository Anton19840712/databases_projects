namespace OneToMany.Models
{
    class AuthorBiographiesContext : DbContext
    {
        // public AuthorBiographiesContext() : base(GetConnectionStringSqlServer(""))
        // {
        //
        // }
        // protected override void OnModelCreating(DbModelBuilder modelBuilder)
        // {
        // }

        public DbSet<Author> Authors { get; set; }
        public DbSet<AuthorBiography> AuthorBiographies { get; set; }
    }
}
