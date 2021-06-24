using Jppapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Jppapi.Data
{
    public class SqlStawkiRepo : IStawkieRepo
    {

        private  RozliczenieContext _context;

        public SqlStawkiRepo(RozliczenieContext context)
        {
            _context = context;
        }

        public void CreateStawka(Stawka stawka)
        {
           if(stawka == null)
            {
                throw new ArgumentNullException(nameof(stawka));
            }

            _context.Stawki.Add(stawka);
        }

        public void DeleteStawka(Stawka stawka)
        {
            if (stawka == null)
            {
                throw new ArgumentNullException(nameof(stawka));
            }

            _context.Stawki.Remove(stawka);
        }

        public IEnumerable<Stawka> GetAllStawki()
        {
            return _context.Stawki.ToList();
        }

        public IEnumerable<Stawka> GetownStawki(string login)
        {
             return _context.Stawki.Where(x=>x.Login.ToUpper()==login.ToUpper()).ToList();
        }

        public Stawka GetStawkaById(int id)
        {
            return _context.Stawki.FirstOrDefault(p => p.Stawki_id == id);
        }

        public bool SaveChanges()
        {
           return ( _context.SaveChanges() >=0);
        }

        public void UpdateStawka(Stawka stawka)
        {
           //nothing
        }
    }
}
