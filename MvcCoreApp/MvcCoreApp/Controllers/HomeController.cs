﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //return new ContentResult() { Content = "Olá Mundo!", ContentType = "text/json" };
            return View();
        }
    }
}
