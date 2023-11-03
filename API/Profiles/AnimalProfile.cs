using System.Collections.Specialized;
using API.Data.Dtos;
using API.Models;
using AutoMapper;

namespace API.Profiles
{
    public class AnimalProfile : Profile{
        public AnimalProfile(){
            CreateMap<CreateAnimalDto, Animal>();
            CreateMap<Animal, ReadAnimalDto>()
            .ForMember(animalDto => animalDto.Raca, opt => opt.MapFrom(animal => animal.Raca));
        }
    }
}