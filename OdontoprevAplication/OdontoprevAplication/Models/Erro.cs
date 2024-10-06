using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Odontoprev.Domain
{
    [Table("Erros")]
    public class Erro
    {
        [Key]
        public int IdErro { get; set; }

        public int? UsuarioId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Mensagem { get; set; }

        [Required]
        public DateTime DataOcorrencia { get; set; }

        // Relacionamento com Usuario 
        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }
    }
}

