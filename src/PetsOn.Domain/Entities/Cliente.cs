using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetsOn.Domain.Entities
{
    public class Cliente : EntityBase
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string Endereco { get; set; }

        [ForeignKey("Petshop")]
        public int Id_Petshop { get; set; }
        public Petshop Petshop { get; set; }
        public ICollection<Animal> Animais { get; set; }

        public ICollection<OrdemServico> OrdemServicos { get; set; }
    }
}
