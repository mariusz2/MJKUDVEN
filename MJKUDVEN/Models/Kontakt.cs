using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MJKUDVEN.Models
{
    [Table("tblKontakt")]
    public class Kontakt
    {
        [Key]
        public int KontaktyId { get; set; }
        public string Nazwisko { get; set; }
        public string Imie { get; set; }
        public string Miasto { get; set; }
        public string Ulica { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public int GrupaID { get; set; }
    }
}