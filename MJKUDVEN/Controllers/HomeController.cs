using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MJKUDVEN.Controllers
{
    public class HomeController : Controller
    {
        // trace.axd
        // MJKUDVEN/home/index/9?Name=mariusz
        public string Index(string id)
        {
            var type = typeof(Controller).Assembly.GetName().Version.ToString();
            return "Hello MVC Aplication - " + type + " Id = " + id + " Name : " + Request.QueryString["Name"];
        }

        public string Test(string id="0", string name="mariusz")
        {
            var type = typeof(Controller).Assembly.GetName().Version.ToString();
            return "Hello MVC Aplication - " + type + " Id = " + id + " Name : " + name;
        }
    }
}