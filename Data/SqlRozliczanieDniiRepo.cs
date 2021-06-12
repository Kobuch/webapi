using Jppapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jppapi.Data
{
    public class SqlRozliczanieDniiRepo : IRozliczanieDniiRepo
    {
        private RozliczenieContext _context;

        public SqlRozliczanieDniiRepo(RozliczenieContext context)
        {
            _context = context;
        }

        public void CreateRozliczenieDnia(RozliczenieDnia rozliczenieDnia)
        {
            if (rozliczenieDnia == null)
            {
                throw new ArgumentNullException(nameof(rozliczenieDnia));
            }

            _context.RozliczeniaDnii.Add(rozliczenieDnia);
        }


        public void DeleteRozliczenieDnia(RozliczenieDnia rozliczenieDnia)
        {
            if (rozliczenieDnia == null)
            {
                throw new ArgumentNullException(nameof(rozliczenieDnia));
            }
            _context.RozliczeniaDnii.Remove(rozliczenieDnia);
        }

        public IEnumerable<RozliczenieDnia> GetAllRozliczenieDnia()
        {
             return _context.RozliczeniaDnii.ToList();
        }

        public IEnumerable<RozliczenieDnia> GetOwnRozliczenieDnia(string login)
        {
            return _context.RozliczeniaDnii.Where(x=>x.Login.ToUpper()==login.ToUpper()).ToList();
        }

        public RozliczenieDnia GetRozliczenieDniaById(int id)
        {
            return _context.RozliczeniaDnii.FirstOrDefault(x => x.Rozliczenie_id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateRozliczenieDnia(RozliczenieDnia rozliczenieDnia)
        {
            //nothing
        }
    }
}
