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
public class SolicAdopController : ControllerBase
{
    SolicAdopContext _context;

    IMapper _mapper;

    public SolicAdopController(SolicAdopContext context, IMapper mapper){
        _context = context;
        _mapper = mapper;

    }

    public void enviaEmail(int id){
        var solic = _context.solics.FirstOrDefault(solic => solic.Id == id);
        ReadSolicAdopDto solicDto = _mapper.Map<ReadSolicAdopDto>(solic);
        string corpoEmail = String.Format("Dados de solicitação de adoção: \nNome: {0} \nNome do animal: {1}\n CPF: {2} \nCelular: {3} \nDada de nascimento: {4}", 
        solicDto.Nome, solicDto.Animal, solicDto.Cpf, solicDto.Celular, solicDto.DtNascimento.Date);

    }

    [HttpPost]
    public IActionResult cadastrarUsuario([FromForm] CreateSolicAdopDto solicDto)
    {
        SolicAdop solic = _mapper.Map<SolicAdop>(solicDto);
        _context.solics.Add(solic);
        _context.SaveChanges();
        enviaEmail(solic.Id);
        return CreatedAtAction(nameof(pesquisarId), new {id = solic.Id}, solic);
    }

    [HttpGet("{id}")]
    public IActionResult pesquisarId(int id){
        var solic = _context.solics.FirstOrDefault(solic => solic.Id == id);
        if(solic == null) return NotFound();
        var solicDto = _mapper.Map<ReadSolicAdopDto>(solic);
        return Ok(solicDto);
    }
}
