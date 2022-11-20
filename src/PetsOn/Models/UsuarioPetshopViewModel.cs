using PetsOn.Helpers;
using System.ComponentModel.DataAnnotations;
using System.Runtime.ConstrainedExecution;

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
        [StringLength(10, MinimumLength = 4, ErrorMessage = "A senha deve ter no mínimo 4 dígitos e no máximo 10.")]
        public string Senha { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Confirme a senha de acesso!")]
        [Compare("Senha", ErrorMessage = "A senha e a confirmação da senha são diferentes!")]
        public string ConfirmaSenha { get; set; }

        public int? Codigo_Petshop { get; set; }

        [Required(ErrorMessage = "Informe o nome da empresa!")]
        public string Nome_Empresa { get; set; }

        [Display(Name = "CNPJ")]
        [Required(ErrorMessage = "Informe o CNPJ!")]
        [Cnpj(ErrorMessage = "O valor do '{0}' é inválido!")]
        public string Cnpj { get; set; }

        [Required(ErrorMessage = "Informe o web-site!")]
        public string Web_Site { get; set; }

        [Required(ErrorMessage = "Informe uma Descrição sobre sua empresa!")]
        public string Descricao { get; set; }

       
    }
}
