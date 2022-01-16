namespace OneToOne.Models
{
    class FluentAuthorContext : DbContext
    {
        // protected override void OnModelCreating(DbModelBuilder modelBuilder)
        // {
        //     modelBuilder.Entity<Author>()
        //         .HasOptional(a => a.Biography)
        //         .WithRequired(ab => ab.Author);
        // }
    }
}
