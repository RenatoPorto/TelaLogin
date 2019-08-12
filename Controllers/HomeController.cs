using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using ProjetoLogin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoLogin.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            return View("Login");
        }

        [HttpPost]
        public IActionResult Login(Login logar)
        {
            if (string.IsNullOrEmpty(logar.Email))
            {
                ModelState.AddModelError(nameof(logar.Email),
                "Informe seu E-mail");
            }

            if (string.IsNullOrEmpty(logar.Senha))
            {
                ModelState.AddModelError(nameof(logar.Senha),
                "Informe sua enha");
            }
          

            if (ModelState.IsValid)
            {
                return View("Confirmarlogin", logar);
            }
            else
            {
                return View(logar);
            }
        }

    }

}

