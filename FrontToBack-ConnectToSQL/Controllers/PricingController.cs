using Microsoft.AspNetCore.Mvc;

namespace FrontToBack_ConnectToSQL.Controllers
{
    public class PricingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
