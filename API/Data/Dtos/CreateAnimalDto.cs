using System.ComponentModel.DataAnnotations;
using API.Models;

namespace API.Data.Dtos
{
    public class CreateAnimalDto{

        [Required]
        public string ?Nome { get; set; }
        
        public string ?Imagens { get; set; }

        [Required]
        public int RacaId { get; set; }

        [Required]
        public int Idade { get; set; }

        public int Peso { get; set; }

        [Required]
        public string ?Porte { get; set; }

        [Required]
        public string ?Local { get; set; }

        public string ?Desc { get; set; }

        [Required]
        public bool Status { get; set; }
    }
}