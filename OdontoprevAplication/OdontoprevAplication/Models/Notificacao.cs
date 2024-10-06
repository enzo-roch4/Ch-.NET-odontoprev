using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Odontoprev.Domain
{
    [Table("Notificacoes")]
    public class Notificacao
    {
        [Key]
        public int IdNotificacoes { get; set; }

        [Required]
        public int UsuarioId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Mensagem { get; set; }

        [Required]
        public DateTime DataNotificacao { get; set; }

        [Required]
        public bool Lida { get; set; } = false; 

        // Relacionamento com Usuario
        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }
    }
}

