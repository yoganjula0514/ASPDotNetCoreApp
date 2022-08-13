using BookListRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookListRazor.Pages.BookList
{
    public class IndexModel : PageModel
    {
        public List<Book> Books { get;set; }

        public void OnGet()
        {
            Books = new List<Book>();
            Books.AddRange(BookContainer.Books);
        }
    }
}
