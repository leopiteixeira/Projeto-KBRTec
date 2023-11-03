using System.Collections.Specialized;
using API.Data.Dtos;
using API.Models;
using AutoMapper;

namespace API.Profiles
{
    public class RacaProfile : Profile{
        public RacaProfile(){
            CreateMap<Raca, ReadRacaDto>()
            .ForMember(racaDto => racaDto.Especie, opt => opt.MapFrom(raca => raca.Especie));
        }
    }
}