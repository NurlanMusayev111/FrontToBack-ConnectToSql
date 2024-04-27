using Microsoft.AspNetCore.Mvc;

namespace FrontToBack_ConnectToSQL.Controllers
{
	public class ContactController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
