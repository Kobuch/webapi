using Jppapi.Models;
using System.Collections.Generic;


namespace Jppapi.Data
{
    public interface IStawkieRepo
    {
        bool SaveChanges();

        IEnumerable<Stawka> GetAllStawki();
        IEnumerable<Stawka> GetownStawki(string login);
        Stawka GetStawkaById(int id);
        void CreateStawka(Stawka stawka);
        void UpdateStawka(Stawka stawka);
        void DeleteStawka(Stawka stawka);

    }
}
