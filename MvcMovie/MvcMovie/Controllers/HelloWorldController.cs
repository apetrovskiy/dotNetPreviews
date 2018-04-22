// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcMovie.Controllers
{
	using Microsoft.AspNetCore.Mvc;
	using System.Text.Encodings.Web;

	public class HelloWorldController : Controller
    {
		// GET: /HelloWorld/
		// 1
		// public string Index()
		// 4
		public IActionResult Index()
		{
			// 1
			// return "This is my default action...";
			// 4
			return View();
        }

		// GET: /HelloWorld/Welcome/
		// 1
		// public string Welcome()
		// 2
		// public string Welcome(string name, int numTimes = 1)
		// 3
		public string Welcome(string name, int ID = 1)
		{
			// 1
			// return "This is the Welcome action method...";
			// 2
			// return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
			// 3
			return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
		}
    }
}
