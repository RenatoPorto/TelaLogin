using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace ProjetoLogin.Models
{
    public class Login

    {
        [Required(ErrorMessage ="O e-mail é obrigatario.!")]
        [DataType(DataType.EmailAddress)]       
        public string Email { get; set; }

        [Required(ErrorMessage ="Senha é obrigatorio.!")]
        [StringLength(3,MinimumLength = 3)]
        public string Senha { get; set; }


    }
}
