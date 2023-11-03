using System.Collections.Specialized;
using API.Data.Dtos;
using API.Models;
using AutoMapper;

namespace API.Profiles
{
    public class SolicAdopProfile : Profile{
        public SolicAdopProfile(){
            CreateMap<CreateSolicAdopDto, SolicAdop>();
            CreateMap<SolicAdop, ReadSolicAdopDto>()
            .ForMember(solicDto => solicDto.Animal, opt => opt.MapFrom(solic => solic.Animal));
        }
    }
}