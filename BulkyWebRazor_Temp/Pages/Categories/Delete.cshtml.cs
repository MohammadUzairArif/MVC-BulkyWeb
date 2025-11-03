using BulkyWebRazor_Temp.Data1;
using BulkyWebRazor_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWebRazor_Temp.Pages.Categories
{
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDBContext _db;
        [BindProperty] // to bind the data from the form to this property automatically on post request 
        public Category Category { get; set; }

        public DeleteModel(ApplicationDBContext db)
        {
            _db = db;
        }
        public void OnGet(int? id)
        {
            if (id != null && id != 0)
            {
                Category = _db.categories.Find(id);
            }

        }

        public IActionResult OnPost()
        {
            Category? obj = _db.categories.Find(Category.Id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.categories.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Category deleted successfully";
            return RedirectToPage("Index");
        }
        

    }
}
