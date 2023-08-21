using ATLibraryMS.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;

namespace ATLibraryMS.Controllers
{
    public class CascadingController : Controller
    {
        private readonly MyAppDbContext _context;

        public CascadingController(MyAppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public JsonResult Categories()
        {
            var categories = _context.Categories.OrderBy(x => x.Category_Name).ToList();
            return new JsonResult(categories);
        }

        public JsonResult BookTitle(int cat_id)
        {
            var booktitle = _context.BooksCategories.Where(x => x.Category_ID == cat_id).OrderBy(x => x.Name).ToList();
            return new JsonResult(booktitle);
        }


    }
}
