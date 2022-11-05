using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace PetsOn.Domain.Entities
{
    public class Petshop : EntityBase
    {
        public string Nome_Empresa { get; set; }
        public string Cnpj { get; set; }
        public string Web_Site { get; set; }
        public string Descricao { get; set; }
        public ICollection<Cliente> Clientes { get; set; }
    }
}
