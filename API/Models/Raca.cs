using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Raca{

        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string ?Nome { get; set; }

        [Required]
        public int EspecieId { get; set; }

        public virtual Especie ?Especie { get; set; }

        public virtual ICollection<Animal> ?Animais { get; set; }
    }
}