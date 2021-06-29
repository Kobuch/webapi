using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jppapi.Dtos
{
    public class RozliczeniaDniaReadDto
    {
  
        public int Rozliczenie_id { get; set; }
        public DateTime Data { get; set; }
        public int NrPracownika { get; set; }
        public string Login { get; set; }
        public string Gdzie { get; set; }
        public decimal? StawkaDzienna { get; set; }
        public int? Procent { get; set; }
        public decimal? Dniowka { get; set; }
        public bool NoWorkDay { get; set; }
    }
}
