using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MJKUDVEN.Models
{
    [Table("tblGrupa")]
    public class Grupa
    {
        [Key]
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public List<Kontakt> Kontakty { get; set; }
    }
}