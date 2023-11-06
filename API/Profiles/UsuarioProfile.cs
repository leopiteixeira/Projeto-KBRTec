using System.Collections.Specialized;
using API.Data.Dtos;
using API.Models;
using AutoMapper;

namespace API.Profiles
{
    public class UsuarioProfile : Profile{
        public UsuarioProfile(){
            CreateMap<CreateUsuarioDto, Usuario>();
        }
    }
}