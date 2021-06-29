using Jppapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jppapi.Data
{
   public interface ILogowanieRepo
    {
        bool SaveChanges();
        bool CzyMaUprawnienia(String login);

        IEnumerable<Logowanie> GetAllLogowania();
        Logowanie GetLogowanieById(int id);
        void CreateLogowanie(Logowanie logowanie);
        void UpdateLogowanie(Logowanie logowanie);
        void DeleteLogowanie(Logowanie logowanie);

        Logowanie CzyMaDostep(string login, string password);
    }
}
