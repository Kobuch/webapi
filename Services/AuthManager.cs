using Jppapi.Data;
using Jppapi.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Jppapi.Services
{
    public class AuthManager : IAuthManager
    {
        private readonly string key;

        private readonly ILogowanieRepo logowanieRepo;

  

        public AuthManager(ILogowanieRepo logowanieRepo)
        {
            this.key = "Zastapic potem kluczem usera"; ;
            this.logowanieRepo = logowanieRepo;
        }

        public userAuth Autenticate(string username, string password)
        {
            Logowanie logowanie;

            var wynik=logowanieRepo.CzyMaDostep(username, password);

            if (wynik is null)
            {
                return new userAuth();
            }
            else
                logowanie = wynik;

            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.ASCII.GetBytes(key);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new System.Security.Claims.ClaimsIdentity(new Claim[] {

                new Claim(ClaimTypes.Name, username)
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey),
                SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);


            userAuth user = new userAuth { Login = logowanie.Login, Login_id = logowanie.Login_id, Token = tokenHandler.WriteToken(token) };


            return user;



        }

      
    }
}
