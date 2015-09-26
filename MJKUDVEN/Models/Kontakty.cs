using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MJKUDVEN.Models
{
    public class Kontakty
    {
        public string Nazwisko;
        public int KontaktyId { get; set; }
        public string Nzawisko { get; set; }
        public string Imie { get; set; }
        public string Miasto { get; set; }
        public string Ulica { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
    }
}