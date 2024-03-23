using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIBiblioteca.Entities
{
    [Table("tbCliente")]
    public class Cliente
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }
        [Column("Nome")]
        public string Nome { get; set; }
        [Column("Endereco")]
        public string Endereco { get; set; }
        [Column("Cidade")]
        public string Cidade { get; set; }
        [Column("Bairro")]
        public string Bairro { get; set; }
        [Column("Numero")]
        public string Numero { get; set; }
        [Column("TelefoneCelular")]
        public string Telefone_Celular { get; set; }
        [Column("TelefoneFixo")]
        public string Telefone_Fixo { get; set; }
        [Column("Email")]
        public string Email { get; set; }
    }
}
