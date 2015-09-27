using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MJKUDVEN.Models
{
    public class KontaktyContext :DbContext
    {
        public DbSet<Kontakt> Kontakty { get; set; }
        public DbSet<Grupa> Grupy { get; set; }
    }
}