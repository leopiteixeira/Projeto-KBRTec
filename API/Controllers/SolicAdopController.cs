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

    [HttpPost]
    public IActionResult cadastrarSolic([FromForm] CreateSolicAdopDto solicDto)
    {
        SolicAdop solic = _mapper.Map<SolicAdop>(solicDto);
        _context.solics.Add(solic);
        _context.SaveChanges();
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
