using Microsoft.AspNetCore.Mvc;
using WebAPIBiblioteca.Entities;
using WebAPIBiblioteca.Services.Implementations.ClienteImplementations;

namespace WebAPIBiblioteca.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : Controller
    {
        private IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_clienteService.GetClientes());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var cliente = _clienteService.GetById(id);
            if (cliente == null)
            {
                return NotFound();
            }
            return Ok(cliente);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Cliente cliente)
        {
            if (cliente == null)
            {
                return BadRequest();
            }

            return Ok(_clienteService.Create(cliente));
        }
        [HttpPut]
        public IActionResult Put([FromBody] Cliente cliente)
        {
            if (cliente == null)
            {
                return BadRequest();
            }

            return Ok(_clienteService.Update(cliente));
        }
        [HttpDelete]
        public IActionResult Delete([FromBody] Cliente cliente)
        {
            _clienteService.Delete(cliente);
            return NoContent();
        }
    }
}
