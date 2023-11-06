using API.Data.Dtos;
using API.Models;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    [Route("[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private IMapper _mapper;
        private UserManager<Usuario> _userManager;

        public UsuarioController(IMapper mapper, UserManager<Usuario> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> adicionaUsuario([FromForm] CreateUsuarioDto userDto)
        {
            Usuario user = _mapper.Map<Usuario>(userDto);
            IdentityResult result = await _userManager.CreateAsync(user, userDto.Password);

            if(result.Succeeded) return Ok("Usuario Cadastrado!");
            throw new ApplicationException("Falha ao cadastrar usuario!");
        }
    }
}