using ChapterFS15.Interfaces;
using ChapterFS15.Models;
using ChapterFS15.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChapterFS15.Controllers
{
    [Produces("application/json")]  
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _iUsuarioRepository;

        public UsuarioController(IUsuarioRepository iUsuarioRepository)
        {
            _iUsuarioRepository = iUsuarioRepository;
        }

        [HttpGet]
        public IActionResult Listar() 
        {
            try 
            {
                return Ok(_iUsuarioRepository.Listar());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        [HttpGet("{id}")]
        public IActionResult BuscaPorId(int id)    
        {
            try
            {
                Usuario usuarioEncontrado = _iUsuarioRepository.BuscarPorId(id);

                if (usuarioEncontrado == null)
                {
                    return NotFound();
                }

                return Ok(usuarioEncontrado);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpPost]
        public IActionResult Cadastrar(Usuario usuario) 
        {
            try 
            {
                _iUsuarioRepository.Cadastrar(usuario);
                return StatusCode(201);
            }
           catch (Exception e) 
            {
                throw new Exception(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id) 
        {
            try 
            {
                _iUsuarioRepository.Deletar(id);
                return Ok("Usuário removido!");
            }
            catch(Exception e) 
            {
                throw new Exception(e.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Usuario usuario)
        {
            try
            {
                _iUsuarioRepository.Atualizar(id, usuario);
                return Ok("Atualizado com sucesso!");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

       

    }
}
