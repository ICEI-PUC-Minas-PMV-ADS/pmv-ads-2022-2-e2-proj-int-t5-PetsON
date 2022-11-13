using System.ComponentModel.DataAnnotations;

namespace PetsOn.Models
{
    public class UsuarioPetshopViewModel
    {
        [Required(ErrorMessage = "Informe o nome do usuário!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o sobrenome do usuário!")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "Informe o e-mail de cadastro!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a senha de acesso!")]
        public string Senha { get; set; }

        public int? Codigo_Petshop { get; set; }

        [Required(ErrorMessage = "Informe o nome da empresa!")]
        public string Nome_Empresa { get; set; }

        [Required(ErrorMessage = "Informe o CNPJ!")]
        public string Cnpj { get; set; }

        [Required(ErrorMessage = "Informe o web-site!")]
        public string Web_Site { get; set; }

        [Required(ErrorMessage = "Informe uma Descrição sobre sua empresa!")]
        public string Descricao { get; set; }

       
    }
}
