using System.Collections.Specialized;
using API.Data.Dtos;
using API.Models;
using AutoMapper;

namespace API.Profiles
{
    public class EspecieProfile : Profile{
        public EspecieProfile(){
            CreateMap<Especie, ReadEspecieDto>();
        }
    }
}