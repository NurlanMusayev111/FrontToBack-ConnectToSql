﻿using Microsoft.AspNetCore.Mvc;

namespace FrontToBack_ConnectToSQL.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
