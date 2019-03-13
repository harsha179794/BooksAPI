using Microsoft.EntityFrameworkCore;

namespace BooksAPI.Models
{
    public class BooksContext : DbContext
    {
        public BooksContext(DbContextOptions<BooksContext> options)
           : base(options)
        {
        }
        public DbSet<BooksItem> BookItems { get; set; }
    }
}
