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
	}
}
