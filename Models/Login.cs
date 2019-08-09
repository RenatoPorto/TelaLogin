using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoLogin.Models
{
    public class Login

    {   [EmailAddress]
        public string Email { get; set; }
        [StringLength(3)]
        public string Senha { get; set; }
    }
}
