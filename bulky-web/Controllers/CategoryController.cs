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

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category obj)
        {
            _db.categories.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
