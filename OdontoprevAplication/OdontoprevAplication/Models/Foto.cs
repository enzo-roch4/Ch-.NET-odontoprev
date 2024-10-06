using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Odontoprev.Domain
{
    [Table("Fotos")]
    public class Foto
    {
        [Key]
        public int IdFotos { get; set; }

        [Required]
        public int UsuarioId { get; set; }

        [Required]
        [MaxLength(255)]
        public string CaminhoFoto { get; set; }

        [Required]
        public DateTime DataEnvio { get; set; }

        // Relacionamento com Usuario
        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }
    }
}
