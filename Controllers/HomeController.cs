using Microsoft.AspNetCore.Mvc;
using ProjetoLogin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoLogin.Controllers
{
    public class HomeController :  Controller
    {
        public IActionResult Index()
        {
            return View("Login");
        }

        [HttpPost]
        public ViewResult Login(Login Logar)
        {
            return View("ConfirmarLogin", Logar);
        }

    }
   
}
            
