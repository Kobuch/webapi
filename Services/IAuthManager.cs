using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jppapi.Services
{
   public interface IAuthManager
    {
        userAuth Autenticate(string username, string password);

    }
}
