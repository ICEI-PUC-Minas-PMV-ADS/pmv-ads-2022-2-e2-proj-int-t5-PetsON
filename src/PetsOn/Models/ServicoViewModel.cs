using PetsOn.Helpers;
using System.ComponentModel.DataAnnotations;

namespace PetsOn.Models
{
    public class ServicoViewModel

    {
        public int? Codigo_Servico { get; set; }

        public int Codigo_Petshop { get; set; }

        [Required(ErrorMessage = "Informe o tipo de serviço!")]
        public string Tipo_Servico { get; set; }

        [Required(ErrorMessage = "Informe a descrição do serviço!")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Informe o preço do serviço!")]
        public decimal Preco { get; set; }
    }
}
