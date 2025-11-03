using BulkyWebRazor_Temp.Data1;
using BulkyWebRazor_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWebRazor_Temp.Pages.Categories
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDBContext _db;
        [BindProperty] // to bind the data from the form to this property automatically on post request 
        public Category Category { get; set; }

        public EditModel(ApplicationDBContext db)
        {
            _db = db;
        }
        public void OnGet(int? id)
        {
            if (id != null && id!=0 ) {
                Category = _db.categories.Find(id);
            }

        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _db.categories.Update(Category);
                _db.SaveChanges();
                TempData["success"] = "Category updated successfully";
                return RedirectToPage("Index");
            }
            TempData["error"] = "Something went wrong!";
            return Page();
        }
    }
}
