using Microsoft.EntityFrameworkCore;
using WebAPIBiblioteca.Entities;

namespace WebAPIBiblioteca.Data.Context
{
    public class SQLServerContext : DbContext
    {
        public SQLServerContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes {  get; set; }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Emprestimo> Emprestimos { get; set; }
    }
}
