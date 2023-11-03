using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Especie{

        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string ?Nome { get; set; }

        public virtual ICollection<Raca> ?Racas { get; set; }
    }
}