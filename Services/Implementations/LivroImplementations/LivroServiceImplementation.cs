using Microsoft.EntityFrameworkCore;
using WebAPIBiblioteca.Data.Context;
using WebAPIBiblioteca.Entities;

namespace WebAPIBiblioteca.Services.Implementations.LivroImplementations
{
    public class LivroServiceImplementation : ILivroService
    {
        private SQLServerContext _livrocontext;

        public LivroServiceImplementation(SQLServerContext livrocontext)
        {
            _livrocontext = livrocontext;
        }

        public async Task<Livro> Create(Livro Livro)
        {
            _livrocontext.Add(Livro);
            await _livrocontext.SaveChangesAsync();
            return Livro;
        }

        public async Task<Livro> Delete(Livro Livro)
        {
            _livrocontext.Add(Livro);
            await _livrocontext.SaveChangesAsync();
            return Livro;
        }

        public async Task<Livro> Update(Livro Livro)
        {
            _livrocontext.Add(Livro);
            await _livrocontext.SaveChangesAsync();
            return Livro;
        }

        public async Task<Livro> GetById(int? Id)
        {
            return await _livrocontext.Livros.FindAsync(Id);
        }

        public async Task<IEnumerable<Livro>> GetLivros()
        {
            return await _livrocontext.Livros.OrderBy(c => c.Nome).ToListAsync();
        }
    }
}
