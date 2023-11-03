using API.Data;
using API.Data.Dtos;
using API.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EspecieController : ControllerBase
    {

        SolicAdopContext _context;

        IMapper _mapper;

        public EspecieController(SolicAdopContext context, IMapper mapper){
            _context = context;
            _mapper = mapper;

        }
        
        [HttpPost]
        public IActionResult adicionaRaca([FromBody] Especie especie){
            _context.especies.Add(especie);
            _context.SaveChanges();
            
            return CreatedAtAction(nameof(pesquisarId), new {id = especie.Id}, especie);
        }

        [HttpGet("{id}")]
        public IActionResult pesquisarId(int id){
            var especie = _context.especies.FirstOrDefault(especie => especie.Id == id);
            if(especie == null) return NotFound();
            var especieDto = _mapper.Map<ReadEspecieDto>(especie);
            return Ok(especieDto);
        }
    }
}