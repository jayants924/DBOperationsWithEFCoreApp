using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;

namespace DBOperationsWithEFCoreApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Currency>().HasData(
                new Currency() { Id = 1, Title = "INR", Description = "Indian INR" },
                new Currency() { Id = 2, Title = "USD", Description = "United States Dollar" },
                new Currency() { Id = 3, Title = "CAD", Description = "Canadian Dollar" },
                new Currency() { Id = 4, Title = "EUR", Description = "Euro" },
                new Currency() { Id = 5, Title = "GBP", Description = "British Pound" }
                );

            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = 1, Title = "English", Description = "English Language" },
                new Language() { Id = 2, Title = "Hindi", Description = "Hindi Language" },
                new Language() { Id = 3, Title = "French", Description = "French Language" },
                new Language() { Id = 4, Title = "German", Description = "German Language" },
                new Language() { Id = 5, Title = "Spanish", Description = "Spanish Language" }
                );
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<BookPrice> BookPrices { get; set; }
    }
}
