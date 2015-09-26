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
        public string Test(string id)
        {
            var type = typeof(Controller).Assembly.GetName().Version.ToString();
            return "Hello MVC Aplication - " + type + " Id = " + id + " Name : " + Request.QueryString["Name"];
        }

        public string Test2(string id="0", string name="mariusz")
        {
            var type = typeof(Controller).Assembly.GetName().Version.ToString();
            return "Hello MVC Aplication - " + type + " Id = " + id + " Name : " + name;
        }

        public List<string> IndexTest()
        {
            return new List<string>()
            {
                "Polska", "Niemcy", "Hiszpania", "Anglia"
            };
        }

        public ActionResult Index()
        {
            ViewBag.Kraje  =  new List<string>()
            {
                "Polska", "Niemcy", "Hiszpania", "Anglia", "Meksyk", "Portugalia", "Włochy"
            };

            return View();
        }
    }
}