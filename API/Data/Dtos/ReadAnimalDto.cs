using System.ComponentModel.DataAnnotations;
using API.Models;

namespace API.Data.Dtos
{
    public class ReadAnimalDto{

        public string ?Nome { get; set; }
        public string ?Imagens { get; set; }
        public int RacaId { get; set; }
        public ReadRacaDto ?Raca { get; set; }
        public int Idade { get; set; }
        public int Peso { get; set; }
        public string ?Porte { get; set; }
        public string ?Local { get; set; }
        public string ?Desc { get; set; }
        public bool Status { get; set; }
    }
}