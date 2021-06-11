using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Jppapi.Models
{
    public class Stawka
    {
        [Key]
        public int Stawki_id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Login { get; set; }
 
        public Nullable<decimal> Stawka_podstawowa { get; set; }

        public Nullable<decimal> Dniowka_zagraniczna { get; set; }
    }
}
