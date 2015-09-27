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
        public ActionResult Index(int grupaId)
        {
            KontaktyContext kontaktyContext = new KontaktyContext();
            List<Kontakt> kontakty = kontaktyContext.Kontakty.Where(k => k.GrupaID == grupaId).ToList();

            return View(kontakty);
        }

        public ActionResult Szczegoly(int id)
        {
            KontaktyContext kontaktyContext = new KontaktyContext();
            Kontakt kontakt = kontaktyContext.Kontakty.Single(k => k.KontaktyId == id);
              //Kontakt test = kontaktyContext.Kontakty.Find(id);

            return View(kontakt);
        }
    }
}