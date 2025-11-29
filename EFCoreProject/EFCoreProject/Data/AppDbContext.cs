using Microsoft.EntityFrameworkCore;

namespace EFCoreProject.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> dbContextOptions):DbContext(dbContextOptions)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CurrencyType>().HasData(
                new CurrencyType { Id = 1, Currency = "INR", Description = "INdian Inr" },
                new CurrencyType { Id = 2, Currency = "Dollar", Description = "Dollar" },
                new CurrencyType { Id = 3, Currency = "Euro", Description = "Euro" },
                new CurrencyType { Id = 4, Currency = "Dinar", Description = "Dinar" }
                
                );
            modelBuilder.Entity<Language>().HasData(
                new Language { Id = 1, Title = "Hindi", Description = "Hindi" },
                new Language { Id = 2, Title = "Tamil", Description = "Tamil" },
                new Language { Id = 3, Title = "Eng", Description = "Euro" },
                new Language { Id = 4, Title = "urdu", Description = "urdu" }
                
                );
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<BookPrice> BookPrices { get; set; }
      public   DbSet<CurrencyType> Currencies { get; set; }
      public   DbSet<Author> Authors { get; set; }
    }
}
