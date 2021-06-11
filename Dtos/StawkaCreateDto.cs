using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Jppapi.Dtos
{
    public class StawkaCreateDto
    {
      
        [Required]
        [MaxLength(50)]
        public string Login { get; set; }

        public Nullable<decimal> Stawka_podstawowa { get; set; }

        public Nullable<decimal> Dniowka_zagraniczna { get; set; }
    }
}
