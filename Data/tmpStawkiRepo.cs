using Jppapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jppapi.Data
{
    public class TmpStawkiRepo : IStawkieRepo
    {
        public void CreateStawka(Stawka stawka)
        {
            throw new NotImplementedException();
        }

        public void DeleteStawka(Stawka stawka)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Stawka> GetAllStawki()
        {
            var stawki = new List<Stawka>
            {
               new Stawka { Stawki_id = 0, Login = "noname1", Dniowka_zagraniczna = 400, Stawka_podstawowa = 100 },
                  new Stawka { Stawki_id = 1, Login = "noname2", Dniowka_zagraniczna = 450, Stawka_podstawowa = 150 },
                     new Stawka { Stawki_id = 2, Login = "noname3", Dniowka_zagraniczna = 500, Stawka_podstawowa = 200 }
        };

            return stawki;
        }

        public IEnumerable<Stawka> GetownStawki(string login)
        {
            throw new NotImplementedException();
        }

        public Stawka GetStawkaById(int id)
        {
            return new Stawka { Stawki_id = 0, Login = "noname", Dniowka_zagraniczna = 400, Stawka_podstawowa = 100 };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateStawka(Stawka stawka)
        {
            throw new NotImplementedException();
        }
    }
}
