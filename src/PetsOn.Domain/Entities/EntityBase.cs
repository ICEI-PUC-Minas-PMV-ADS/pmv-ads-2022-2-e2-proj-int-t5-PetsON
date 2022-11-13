using System.ComponentModel.DataAnnotations;

namespace PetsOn.Domain.Entities
{
    public class EntityBase
    {
        [Key]
        public int? Id { get; set; } 
    }
}
