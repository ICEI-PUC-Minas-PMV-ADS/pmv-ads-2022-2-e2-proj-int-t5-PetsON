using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetsOn.Domain.Entities
{
    public class Cliente
    {
        [Key]
        public int? Id { get; set; }
        public string Nome { get; set; }
        public int Cpf { get; set; }
        public string Email { get; set; }
        public int Celular { get; set; }
        public string Enderenco { get; set; }

        [ForeignKey("Petshop")]
        public int Id_Petshop { get; set; }
        public Petshop Petshop { get; set; }
        public ICollection<Animal> Animais { get; set; }

        public ICollection<OrdemServico> OrdemServicos { get; set; }
    }
}
