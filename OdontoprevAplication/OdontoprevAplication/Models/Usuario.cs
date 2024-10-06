using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Odontoprev.Domain
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int IdUser { get; set; }

        
        [MaxLength(100)]
        public required string Nome { get; set; }

      
        [MaxLength(11)]
        public required string Cpf { get; set; }

       
        [MaxLength(255)]
        public required string Senha { get; set; }

    
        public required DateTime DataCriacao { get; set; }

        public ICollection<Foto> Fotos { get; set; }

        public ICollection<Notificacao> Notificacoes { get; set; }
    }
}


