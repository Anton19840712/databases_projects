namespace ManyToMany.Models
{
    class AuthorBiographiesContext : DbContext
    {
        // modelBuilder.Entity<Author>()
        // .HasMany(b => b.AuthorBiographies)
        //     .WithMany(c => c.Authors)
        //     .Map(cs =>
        // {
        //     cs.MapLeftKey("AuthorId");
        //     cs.MapRightKey("AuthorBiographyId");
        //     cs.ToTable("AuthorBiographies");
        // });

        public DbSet<Author> Authors { get; set; }
        public DbSet<AuthorBiography> AuthorBiographies { get; set; }
    }
}
