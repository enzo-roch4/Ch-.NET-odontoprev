using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Odontoprev.Domain
{
    [Table("Processo")]
    public class Processo
    {
        [Key]
        public int IdProcesso { get; set; }

        public int? UsuarioId { get; set; }

        [Required]
        public int AnaliseId { get; set; }

        [Required]
        public DateTime DataAnalise { get; set; }

        // Relacionamento com Usuario (N:1)
        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }
    }
}
