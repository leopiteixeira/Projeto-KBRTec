using API.Data;
using API.Data.Dtos;
using API.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RacaController : ControllerBase
    {

        SolicAdopContext _context;

        IMapper _mapper;

        public RacaController(SolicAdopContext context, IMapper mapper){
            _context = context;
            _mapper = mapper;

        }
        
        [HttpPost]
        public IActionResult adicionaRaca([FromBody] Raca raca){
            _context.racas.Add(raca);
            _context.SaveChanges();
            
            return CreatedAtAction(nameof(pesquisarId), new {id = raca.Id}, raca);
        }

        [HttpGet("{id}")]
        public IActionResult pesquisarId(int id){
            var raca = _context.racas.FirstOrDefault(raca => raca.Id == id);
            if(raca == null) return NotFound();
            var racaDto = _mapper.Map<ReadRacaDto>(raca);
            return Ok(racaDto);
        }
    }
}