using Microsoft.AspNetCore.Mvc;

namespace bulky_web.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
