using WebAPIBiblioteca.Entities;

namespace WebAPIBiblioteca.Services.Implementations.EmprestimoImplementations
{
    public interface IEmprestimoService
    {
        Task<IEnumerable<Emprestimo>> GetEmprestimos();
        Task<Emprestimo> GetById(int? Id);
        Task<Emprestimo> Create(Emprestimo emprestimo);
        Task<Emprestimo> Update(Emprestimo emprestimo);
        Task<Emprestimo> Delete(Emprestimo emprestimo);
    }
}
