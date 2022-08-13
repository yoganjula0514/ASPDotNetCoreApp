using BookListRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;

namespace BookListRazor.Pages.BookList
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public Book Book { get; set; }


        public void OnGet(int id)
        {
            foreach (var book in from book in BookContainer.Books
                                 where book.Id == id
                                 select book)
            {
                Book = book;
                break;
            }
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                foreach(var book in BookContainer.Books)
                {
                    if(book.Id == Book.Id)
                    {
                        book.Name = Book.Name;
                        book.Author = Book.Author;
                        book.SBIN = Book.SBIN;
                        break;
                    }
                }

                return RedirectToPage("Index");
            }
            else
            {
                return RedirectToPage();
            }
            
        }
    }
}
