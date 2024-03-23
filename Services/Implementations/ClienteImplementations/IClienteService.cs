using WebAPIBiblioteca.Entities;

namespace WebAPIBiblioteca.Services.Implementations.ClienteImplementations
{
    public interface IClienteService
    {
        Task<IEnumerable<Cliente>> GetClientes();
        Task<Cliente> GetById(int? Id);
        Task<Cliente> Create(Cliente cliente);
        Task<Cliente> Update(Cliente cliente);
        Task<Cliente> Delete(Cliente cliente);
    }
}
