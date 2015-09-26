using MJKUDVEN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MJKUDVEN.Controllers
{
    public class KontaktyController : Controller
    {
        public ActionResult Szczegoly()
        {
            Kontakty kontakty = new Kontakty()
            {
                KontaktyId = 1,
                Imie = "Marcin",
                Nazwisko = "Jurczenko",
                Miasto = "Katowice",
                Ulica = "Adama 16/11",
                Email = "marcin@wp.pl",
                Telefon = "667-263-641"
            };

            return View(kontakty);
        }
    }
}