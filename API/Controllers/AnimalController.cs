using Microsoft.AspNetCore.Mvc;
using API.Models;
using API.Data.Dtos;
using API.Data;
using AutoMapper;
using System.Collections.Specialized;
using System.Diagnostics.Contracts;
using System.Net.Mime;
using System.Web;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class AnimalController : ControllerBase
{
    SolicAdopContext _context;

    IMapper _mapper;

    public AnimalController(SolicAdopContext context, IMapper mapper){
        _context = context;
        _mapper = mapper;

    }

    [HttpPost]
    public IActionResult adicionarAnimal([FromBody] CreateAnimalDto animalDto)
    {
        Animal animal = _mapper.Map<Animal>(animalDto);
        _context.animais.Add(animal);
        _context.SaveChanges();
        return CreatedAtAction(nameof(pesquisarId), new {id = animal.Id}, animal);
    }

    [HttpGet]
    public IEnumerable<ReadAnimalDto> mostraAnimais(){

        return _mapper.Map<List<ReadAnimalDto>>(_context.animais.ToList());
    }

    [HttpGet("{id}")]
    public IActionResult pesquisarId(int id){
        var animal = _context.animais.FirstOrDefault(animal => animal.Id == id);
        if(animal == null) return NotFound();
        var animalDto = _mapper.Map<ReadAnimalDto>(animal);
        return Ok(animalDto);
    }
}
