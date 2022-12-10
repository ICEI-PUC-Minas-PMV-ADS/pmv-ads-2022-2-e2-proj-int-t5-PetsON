using PetsOn.Domain.Entities;
using PetsOn.Helpers;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetsOn.Models
{
    public class OrdemServicoViewModel

    {
        public int? Codigo_OrdemServico { get; set; }
        public DateTime Data { get; set; }
        public DateTime Data_realizacao { get; set; }
        public DateTime Data_Agendamento { get; set; }

        [Required(ErrorMessage = "Informe a observação da Ordem Serviço!")]
        public string Observacao { get; set; }

        public int Codigo_Animal { get; set; }
        public int Codigo_Cliente { get; set; }
        public int Codigo_Petshop { get; set; }


    }
}
