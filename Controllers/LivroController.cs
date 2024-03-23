using Microsoft.AspNetCore.Mvc;
using WebAPIBiblioteca.Entities;
using WebAPIBiblioteca.Services.Implementations.LivroImplementations;

namespace WebAPIBiblioteca.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LivroController : Controller
    {
        private ILivroService _livroService;

        public LivroController(ILivroService livroService)
        {
            _livroService = livroService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_livroService.GetLivros());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var livro = _livroService.GetById(id);
            if (livro == null)
            {
                return NotFound();
            }
            return Ok(livro);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Livro livro)
        {
            if (livro == null)
            {
                return BadRequest();
            }

            return Ok(_livroService.Create(livro));
        }
        [HttpPut]
        public IActionResult Put([FromBody] Livro livro)
        {
            if (livro == null)
            {
                return BadRequest();
            }

            return Ok(_livroService.Update(livro));
        }
        [HttpDelete]
        public IActionResult Delete([FromBody] Livro livro)
        {
            _livroService.Delete(livro);
            return NoContent();
        }
    }
}
