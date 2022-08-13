using BookListRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookListRazor.Pages.BookList
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Book Book { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if(ModelState.IsValid)
            {
                BookContainer.Books.Add(Book);
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
