using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetsOn.Domain.Entities
{
    public class Usuario : EntityBase
    {
        public string Nome_Usuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        [ForeignKey("Petshop")]
        public int Id_Petshop { get; set; }
        public Petshop Petshop { get; set; }
    }
}
