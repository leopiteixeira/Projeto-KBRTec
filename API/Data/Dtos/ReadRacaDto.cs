using System.ComponentModel.DataAnnotations;

namespace API.Data.Dtos
{
    public class ReadRacaDto{
        public string ?Nome { get; set; }
        public int EspecieId { get; set; }
        public ReadEspecieDto ?Especie { get; set; }
    }
}