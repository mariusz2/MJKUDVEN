﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MJKUDVEN.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            var type = typeof(Controller).Assembly.GetName().Version.ToString();
            return "Hello MVC Aplication - " + type;
        }
    }
}