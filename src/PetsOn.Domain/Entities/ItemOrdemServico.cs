using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetsOn.Domain.Entities
{
    public class ItemOrdemServico
    {
        public int Id_Ordem_Servico { get; set; }
        public int Id_Servico { get; set; }
        public decimal Preco { get; set; }
        public Servico Servico { get; set; }
        public OrdemServico OrdemServico { get; set; }
    }
}
