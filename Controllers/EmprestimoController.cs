using Microsoft.AspNetCore.Mvc;
using WebAPIBiblioteca.Entities;
using WebAPIBiblioteca.Services.Implementations.EmprestimoImplementations;

namespace WebAPIBiblioteca.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmprestimoController : Controller
    {
        private IEmprestimoService _emprestimoService;

        public EmprestimoController(IEmprestimoService emprestimoService)
        {
            _emprestimoService = emprestimoService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_emprestimoService.GetEmprestimos());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var emprestimo = _emprestimoService.GetById(id);
            if (emprestimo == null)
            {
                return NotFound();
            }
            return Ok(emprestimo);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Emprestimo emprestimo)
        {
            if (emprestimo == null)
            {
                return BadRequest();
            }

            return Ok(_emprestimoService.Create(emprestimo));
        }
        [HttpPut]
        public IActionResult Put([FromBody] Emprestimo emprestimo)
        {
            if (emprestimo == null)
            {
                return BadRequest();
            }

            return Ok(_emprestimoService.Update(emprestimo));
        }
        [HttpDelete]
        public IActionResult Delete([FromBody] Emprestimo emprestimo)
        {
            _emprestimoService.Delete(emprestimo);
            return NoContent();
        }
    }
}
