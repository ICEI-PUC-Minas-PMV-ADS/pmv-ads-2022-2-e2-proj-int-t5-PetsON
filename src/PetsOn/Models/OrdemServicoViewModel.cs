using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PetsOn.Models
{
    public class OrdemServicoViewModel

    {
        public int? Codigo_OrdemServico { get; set; }
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Informe a Data da Realização do atendimento!")]
        public DateTime? Data_Realizacao { get; set; }

        [Required(ErrorMessage = "Informe a Data do Agendamento do atendimento!")]
        public DateTime? Data_Agendamento { get; set; }

        [Required(ErrorMessage = "Informe a observação da Ordem Serviço!")]
        public string Observacao { get; set; }
        public int Codigo_Cliente { get; set; }
        public IEnumerable<SelectListItem> ListaClientes { get; set; }
        public int Codigo_Animal { get; set; }
        public IEnumerable<SelectListItem> ListaAnimais { get; set; }
        public int Codigo_Petshop { get; set; }


    }
}
