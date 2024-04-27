using Microsoft.AspNetCore.Mvc;

namespace FrontToBack_ConnectToSQL.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

	}
}
