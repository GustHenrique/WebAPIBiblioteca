using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIBiblioteca.Entities
{
    [Table("tbEmprestimo")]
    public class Emprestimo
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }
        [Column("IdCliente")]
        public int IdCliente { get; set; }
        [Column("IdLivro")]
        public int IdLivro { get; set; }
        [Column("DataEmprestimo")]
        public DateTime Data_Emprestimo { get; set; }
        [Column("DataEntrega")]
        public DateTime Data_Entrega { get; set; }
        [Column("Entregue")]
        public bool Entregue { get; set; }
    }
}
