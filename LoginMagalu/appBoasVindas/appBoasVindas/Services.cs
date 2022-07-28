using appBoasVindas.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;

namespace appBoasVindas
{
    public class Services
    {
        public async Task Login(HttpContext ct,User user)
        {
            var claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Name, user.nome));



            var claimsIdentity =
              new ClaimsPrincipal(
                  new ClaimsIdentity(
                      claims,
                      CookieAuthenticationDefaults.AuthenticationScheme
                  )
              );

            var authProperties = new AuthenticationProperties
            {
                //tempo de expiracao do cookie
                ExpiresUtc = DateTime.Now.AddHours(8),
                IssuedUtc = DateTime.Now
            };

            await ct.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsIdentity, authProperties);
        }

        public async Task Logoff(HttpContext ct)
        {
            await ct.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        }


    }
}


