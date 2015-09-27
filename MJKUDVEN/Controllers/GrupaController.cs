using MJKUDVEN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MJKUDVEN.Controllers
{
    public class GrupaController : Controller
    {
        // GET: Grupa
        public ActionResult Index()
        {
            KontaktyContext kontaktyContext = new KontaktyContext();
            List<Grupa> grupy = kontaktyContext.Grupy.ToList();

            return View(grupy);
        }
    }
}