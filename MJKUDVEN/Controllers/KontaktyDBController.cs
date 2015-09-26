using MJKUDVEN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MJKUDVEN.Controllers
{
    public class KontaktyDBController : Controller
    {
        public ActionResult Szczegoly(int id)
        {
            KontaktyContext kontaktyContext = new KontaktyContext();
            Kontakt kontakt = kontaktyContext.Kontakty.Single(k => k.KontaktyId == id);

            return View(kontakt);
        }
    }
}