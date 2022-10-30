using System.ComponentModel.DataAnnotations;

namespace PetsOn.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage="Informe o usuário!")]
        public string Nome_Usuario { get; set; }

        [Required(ErrorMessage = "Informe a senha!")]
        public string Senha { get; set; }
    }
}