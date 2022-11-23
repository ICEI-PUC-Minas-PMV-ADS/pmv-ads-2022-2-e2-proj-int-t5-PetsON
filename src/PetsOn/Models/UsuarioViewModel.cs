using System.ComponentModel.DataAnnotations;

namespace PetsOn.Models
{
    public class UsuarioViewModel

    {
        public int? Codigo_Usuario { get; set; }

        [Required(ErrorMessage = "Informe o nome do usuário!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o sobrenome do usuário!")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "Informe o e-mail de cadastro!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a senha de acesso!")]
        public string Senha { get; set; }

    }
}
