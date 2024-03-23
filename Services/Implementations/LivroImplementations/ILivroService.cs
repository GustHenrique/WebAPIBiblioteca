using WebAPIBiblioteca.Entities;

namespace WebAPIBiblioteca.Services.Implementations.LivroImplementations
{
    public interface ILivroService
    {
        Task<IEnumerable<Livro>> GetLivros();
        Task<Livro> GetById(int? Id);
        Task<Livro> Create(Livro Livro);
        Task<Livro> Update(Livro Livro);
        Task<Livro> Delete(Livro Livro);
    }
}
