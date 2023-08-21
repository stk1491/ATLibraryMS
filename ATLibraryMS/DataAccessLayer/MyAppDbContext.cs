using ATLibraryMS.Models;
using Microsoft.EntityFrameworkCore;

namespace ATLibraryMS.DataAccessLayer
{
    public class MyAppDbContext : DbContext
    {
        public MyAppDbContext(DbContextOptions options) : base(options)
        {
                
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<BooksCategory> BooksCategories { get; set; }   

    }
}
