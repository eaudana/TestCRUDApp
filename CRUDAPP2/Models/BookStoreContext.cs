using Microsoft.EntityFrameworkCore;

namespace CRUDAPP2.Models
{
    public class BookStoreContext:DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options) {
        
        }
        public DbSet<Book> Books { get; set; }
    }
}
