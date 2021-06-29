using Jppapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jppapi.Data
{
   public interface IRozliczanieDniiRepo
    {
        bool SaveChanges();

        IEnumerable<RozliczenieDnia> GetAllRozliczenieDnia();
        IEnumerable<RozliczenieDnia> GetOwnRozliczenieDnia(string login);

        RozliczenieDnia GetRozliczenieDniaById(int id);
        void CreateRozliczenieDnia(RozliczenieDnia rozliczenieDnia);
        void UpdateRozliczenieDnia(RozliczenieDnia rozliczenieDnia);
        void DeleteRozliczenieDnia(RozliczenieDnia rozliczenieDnia);
    }
}
