using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jppapi.Dtos
{
    public class StawkaReadDto
    {
        public int Stawki_id { get; set; }
        public string Login { get; set; }
        public Nullable<decimal> Stawka_podstawowa { get; set; }
        public Nullable<decimal> Dniowka_zagraniczna { get; set; }
    
    }
}
