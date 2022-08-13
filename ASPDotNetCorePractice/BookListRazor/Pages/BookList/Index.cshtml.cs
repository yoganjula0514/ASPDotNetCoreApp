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

        public IActionResult OnPostDelete(int id)
        {
            OnGet();

            Book bookToBeDeleted = null;
            foreach (var book in from book in BookContainer.Books
                                 where book.Id == id
                                 select book)
            {
                bookToBeDeleted = book;
                break;
            }

            if(bookToBeDeleted != null)
            {
                BookContainer.Books.Remove(bookToBeDeleted);
            }

            return RedirectToPage("Index");
        }
    }
}
