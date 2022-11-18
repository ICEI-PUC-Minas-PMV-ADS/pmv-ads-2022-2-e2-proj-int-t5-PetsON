using System.ComponentModel.DataAnnotations;

namespace PetsOn.Models
{
    public class ClienteAnimalViewModel

    {
        public int? Codigo_Cliente { get; set; }

        [Required(ErrorMessage = "Informe o nome do cliente!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o CPF do cliente!")]
        public int Cpf { get; set; }

        [Required(ErrorMessage = "Informe o e-mail do cliente!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe o celular do cliente!")]
        public int Celular { get; set; }

        [Required(ErrorMessage = "Informe o endereço do cliente!")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Informe o nome de seu pet!")]
        public string Nome_Animal { get; set; }

        [Required(ErrorMessage = "Informe o idade de seu pet!")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "Informe a raça de seu pet!")]
        public string Raca { get; set; }

        [Required(ErrorMessage = "Informe observações sobre seu pet!")]
        public string Observacao { get; set; }
    }
}
