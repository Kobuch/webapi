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

        public Logowanie CzyMaDostep(string login, string password)
        {
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password)) 
            {
                return null;
            }

            if (_context.Loginy.Any(user =>
                    user.Login.ToUpper() == login.ToUpper() &&
                    user.Password.ToUpper() == password.ToUpper() &&
                   !user.Zablokowany)
               )
            {
                return _context.Loginy.First(user => user.Login.ToUpper() == login.ToUpper());
            }
            else
                return null;


        }



        public bool CzyMaUprawnienia(string login)
        {
            return true;
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
