using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class SolicAdop{

        [Key]
        [Required]
        public int Id { get; set; }
        
        [Required(ErrorMessage ="O campo Nome é obrigatório")]
        [StringLength(100, ErrorMessage = "Tamanho máximo para Nome é de 100 caracteres")]
        public string ?Nome { get; set; }

        [Required]
        public int AnimalId { get; set; }

        public virtual Animal ?Animal { get; set; }

        [Required(ErrorMessage ="O campo Cpf é obrigatório")]
        [StringLength(11, ErrorMessage = "Tamanho máximo para Cpf é de 11 caracteres")]
        public string ?Cpf { get; set; }

        [Required(ErrorMessage ="O campo Email é obrigatório")]
        [StringLength(100, ErrorMessage = "Tamanho máximo para Email é de 100 caracteres")]
        public string ?Email { get; set; }

        [Required(ErrorMessage ="O campo Celular é obrigatório")]
        [StringLength(15, ErrorMessage = "Tamanho máximo para Celular é de 15 caracteres")]
        public string ?Celular { get; set; }

        [Required(ErrorMessage ="O campo Data de Nascimento é obrigatório")]
        public DateTime DtNascimento { get; set; }

        [Required]
        public DateTime DtInsercao { get; set; } = DateTime.Now;
    }
}