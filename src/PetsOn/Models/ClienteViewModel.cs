using PetsOn.Helpers;
using System.ComponentModel.DataAnnotations;

namespace PetsOn.Models
{
    public class ClienteViewModel

    {
        public int? Codigo_Cliente { get; set; }

        [Required(ErrorMessage = "Informe o nome do cliente!")]
        public string Nome { get; set; }

        [Display(Name = "CPF")]
        [Required(ErrorMessage = "Informe o CPF!")]
        [Cpf(ErrorMessage = "O valor '{0}' é inválido")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Informe o E-mail!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe o celular!")]
        public string Celular { get; set; }

        [Required(ErrorMessage = "Informe o endereço!")]
        public string Endereco { get; set; }
    }
}
