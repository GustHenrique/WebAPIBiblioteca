using Microsoft.EntityFrameworkCore;
using WebAPIBiblioteca.Data.Context;
using WebAPIBiblioteca.Entities;

namespace WebAPIBiblioteca.Services.Implementations.ClienteImplementations
{
    public class ClienteServiceImplementation : IClienteService
    {
        private SQLServerContext _clientecontext;

        public ClienteServiceImplementation(SQLServerContext clientecontext)
        {
            _clientecontext = clientecontext;
        }

        public async Task<Cliente> Create(Cliente cliente)
        {
            _clientecontext.Add(cliente);
            await _clientecontext.SaveChangesAsync();
            return cliente;
        }

        public async Task<Cliente> Delete(Cliente cliente)
        {
            _clientecontext.Remove(cliente);
            await _clientecontext.SaveChangesAsync();
            return cliente;
        }

        public async Task<Cliente> Update(Cliente cliente)
        {
            _clientecontext.Update(cliente);
            await _clientecontext.SaveChangesAsync();
            return cliente;
        }
        public async Task<Cliente> GetById(int? Id)
        {
            return await _clientecontext.Clientes.FindAsync(Id);
        }

        public async Task<IEnumerable<Cliente>> GetClientes()
        {
            return await _clientecontext.Clientes.OrderBy(c => c.Nome).ToListAsync();
        }
    }
}
