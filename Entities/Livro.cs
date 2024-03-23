using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIBiblioteca.Entities
{
    [Table("tbEmprestimo")]
    public class Livro
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }
        [Column("Nome")]
        public string Nome { get; set; }
        [Column("Autor")]
        public string Autor { get; set; }
        [Column("Editora")]
        public string Editora { get; set; }
        [Column("DataPublicacao")]
        public DateTime Data_Publicacao { get; set; }
        [Column("Edicao")]
        public string Edicao { get; set; }
    }
}
