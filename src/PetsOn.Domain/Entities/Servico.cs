using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetsOn.Domain.Entities
{
    public class Servico : EntityBase
    {
        public string Tipo_Servico { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        [ForeignKey("Petshop")]
        public int Id_Petshop { get; set; }
        public Petshop Petshop { get; set; }


    }
}
