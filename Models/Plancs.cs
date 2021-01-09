using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Ardelean_Diana_Proiect1.Models
{
    public class Plancs
    {
        public int ID { get; set; }
        [Display(Name = "Numele dumneavoastra")]
        public string Nume { get; set; }
        public string Oras { get; set; }
        public string Tara { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Buget { get; set; }
        public DateTime Perioada { get; set; }
    }
}
