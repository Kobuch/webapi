using Jppapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jppapi.Data
{
    public class SqlLogowanieRepo : ILogowanieRepo
    {
        private RozliczenieContext _context;
        public SqlLogowanieRepo(RozliczenieContext context)
        {
            _context = context;
        }

        public void CreateLogowanie(Logowanie logowanie)
        {
            if (logowanie == null)
            {
                throw new ArgumentNullException(nameof(logowanie));
            }

            _context.Loginy.Add(logowanie);
        }

        public bool CzyMaUprawnienia(string login)
        {
            return _context.Loginy.Any(x => x.Login.ToUpper() == login.ToUpper() && !x.Zablokowany);
        }

        public void DeleteLogowanie(Logowanie logowanie)
        {
            if (logowanie == null)
            {
                throw new ArgumentNullException(nameof(logowanie));
            }

            _context.Loginy.Remove(logowanie);
        }

        public IEnumerable<Logowanie> GetAllLogowania()
        {
            return _context.Loginy.ToList();
        }

        public Logowanie GetLogowanieById(int id)
        {
            return _context.Loginy.FirstOrDefault(p => p.Login_id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateLogowanie(Logowanie logowanie)
        {
          //nothing
        }
    }
}
