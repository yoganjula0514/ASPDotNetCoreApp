using BookListRazor.Model;
using Microsoft.AspNetCore.Mvc;

namespace BookListRazor.Controllers
{
	[Route("api/Book")]
	[ApiController]
	public class BookController : Controller
	{
		[HttpGet]
		public IActionResult GetAll()
		{
			return Json(new {data= BookContainer.Books});
		}

		[HttpDelete]
		public IActionResult Delete(int id)
		{
            Book bookToBeDeleted = null;
            foreach (var book in from book in BookContainer.Books
                                 where book.Id == id
                                 select book)
            {
                bookToBeDeleted = book;
                break;
            }

            if (bookToBeDeleted != null)
            {
                BookContainer.Books.Remove(bookToBeDeleted);
				return Json(new {success=true, message="Delete Success."});
            }
			else
			{
				return Json(new { success = false, message = "Error while deleting book." });
			}
		}
	}
}
