using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Animal{

        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string ?Nome { get; set; }
        
        public string ?Imagem { get; set; }

        [Required]
        public int RacaId { get; set; }

        public virtual Raca ?Raca { get; set; }

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