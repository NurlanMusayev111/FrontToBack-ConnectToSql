﻿using Microsoft.AspNetCore.Mvc;

namespace FrontToBack_ConnectToSQL.Controllers
{
    public class WorkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}