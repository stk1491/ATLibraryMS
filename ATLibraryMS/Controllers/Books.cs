using ATLibraryMS.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ATLibraryMS.Controllers
{
    public class Books : Controller
    {
        private readonly MyAppDbContext _context;

        public Books(MyAppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var books = _context.BooksCategories.Include("Categories");
            return View(books);
        }
    }
}
