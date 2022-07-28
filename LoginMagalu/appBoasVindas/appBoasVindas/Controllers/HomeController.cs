using appBoasVindas.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;

namespace appBoasVindas.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

           

        [AllowAnonymous]
        public IActionResult Index(bool erroLogin)
        {

            if (erroLogin)
            {
                ViewBag.Erro = "Os dados informados estão incorretos!";
            }
            if (HttpContext.User.Identity.IsAuthenticated)
                return RedirectToAction("Profile");
            return View();
        }

        [HttpPost, AllowAnonymous]
        public async Task<IActionResult> Login(User user)
        {
            var usuarioDB = new User()
            {
                nome = "magalu",
                senha = "m@galu123",
               
            };

            if (!usuarioDB.nome.Equals(user.nome) ||
                !usuarioDB.senha.Equals(user.senha)
                )
            {
                return RedirectToAction("Index", new { erroLogin = true });
            }

            await new Services().Login(HttpContext, user);
            return RedirectToAction("Profile");
            
        }

        [Authorize]
        public async Task<IActionResult> Sair()
        {
            await new Services().Logoff(HttpContext);
            return RedirectToAction("Index");
        }

        [Authorize]
        public IActionResult Profile()
        {
            ViewBag.Permissoes = HttpContext.User.Claims.Where(x => x.Type == ClaimTypes.Role).Select(x => x.Value);
            return View();
        }







    }
}