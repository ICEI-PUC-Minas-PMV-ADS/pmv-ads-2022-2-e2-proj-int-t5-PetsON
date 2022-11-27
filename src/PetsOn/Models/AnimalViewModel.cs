using PetsOn.Helpers;
using System.ComponentModel.DataAnnotations;

namespace PetsOn.Models
{
    public class AnimalViewModel

    {
        public int? Codigo_Animal { get; set; }

        public int Codigo_Cliente { get; set; }

        public string? Nome_Cliente { get; set; }

        [Required(ErrorMessage = "Informe do pet!")]
        public string Nome_Animal { get; set; }

        [Required(ErrorMessage = "Informe o idade do pet!")]
        [Range(1, 20, ErrorMessage = "Idade improvável!")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "Informe a raça do pet!")]
        public string Raca { get; set; }

        [Required(ErrorMessage = "Informe observações sobre o pet!")]
        public string Observacao { get; set; }
    }
}
