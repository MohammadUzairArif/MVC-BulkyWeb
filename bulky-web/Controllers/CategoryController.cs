using bulky_web.Data;
using bulky_web.Models;
using Microsoft.AspNetCore.Mvc;

namespace bulky_web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDBContext _db;

        public CategoryController(ApplicationDBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Category> objCategoryList = _db.categories.ToList();
            return View(objCategoryList);
        }
    }
}
