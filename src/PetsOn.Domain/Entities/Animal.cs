using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetsOn.Domain.Entities
{
    public class Animal : EntityBase
    {
        public string Nome_Animal { get; set; }
        public int Idade { get; set; }
        public string Raca { get; set; }
        public string Observacao { get; set; }

        [ForeignKey("Cliente")]
        public int Id_Cliente { get; set; }
        public Cliente Cliente { get; set; }

    }
}
