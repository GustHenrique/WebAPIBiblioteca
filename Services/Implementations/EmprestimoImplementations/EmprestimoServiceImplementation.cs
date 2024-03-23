using Microsoft.EntityFrameworkCore;
using WebAPIBiblioteca.Data.Context;
using WebAPIBiblioteca.Entities;

namespace WebAPIBiblioteca.Services.Implementations.EmprestimoImplementations
{
    public class EmprestimoServiceImplementation : IEmprestimoService
    {
        private SQLServerContext _emprestimocontext;

        public EmprestimoServiceImplementation(SQLServerContext emprestimocontext)
        {
            _emprestimocontext = emprestimocontext;
        }

        public async Task<Emprestimo> Create(Emprestimo emprestimo)
        {
            _emprestimocontext.Add(emprestimo);
            await _emprestimocontext.SaveChangesAsync();
            return emprestimo;
        }

        public async Task<Emprestimo> Delete(Emprestimo emprestimo)
        {
            _emprestimocontext.Remove(emprestimo);
            await _emprestimocontext.SaveChangesAsync();
            return emprestimo;
        }
        public async Task<Emprestimo> Update(Emprestimo emprestimo)
        {
            _emprestimocontext.Update(emprestimo);
            await _emprestimocontext.SaveChangesAsync();
            return emprestimo;
        }

        public async Task<Emprestimo> GetById(int? Id)
        {
            return await _emprestimocontext.Emprestimos.FindAsync(Id);
        }

        public async Task<IEnumerable<Emprestimo>> GetEmprestimos()
        {
            return await _emprestimocontext.Emprestimos.OrderBy(c => c.Data_Emprestimo).ToListAsync();
        }

    }
}