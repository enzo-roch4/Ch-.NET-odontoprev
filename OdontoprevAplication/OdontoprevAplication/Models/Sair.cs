using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Odontoprev.Domain
{
    [Table("Sair")]
    public class Sair
    {
        [Key]
        public int IdSair { get; set; }

        [Required]
        public int UsuarioId { get; set; }

        [Required]
        public DateTime DataSaida { get; set; }

        [Required]
        [MaxLength(45)]
        public string IpEndereco { get; set; }

        [Required]
        [MaxLength(255)]
        public string SessionId { get; set; }

        // Relacionamento com Usuario 
        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }
    }
}
