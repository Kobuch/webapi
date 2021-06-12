using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Jppapi.Dtos
{
    public class RozliczeniaDniaCreateDto
    {
        [Required]
        public DateTime Data { get; set; }
        [Required]
        public int NrPracownika { get; set; }
        public string Login { get; set; }
        public string Gdzie { get; set; }
        public decimal? StawkaDzienna { get; set; }
        public int? Procent { get; set; }
        public decimal? Dniowka { get; set; }
        [Required]
        public bool NoWorkDay { get; set; }
    }
}
