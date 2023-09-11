using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MtecDevs.Models
{
    [Table("Usuarios")] 
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }

        [Required]
        [StringLength(300)]
        public string Nome { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataNascimento { get; set; }

        public string Foto { get; set; }

        [Required]
        [EnumDataType(typeof(TipoDev))]
        public TipoDev TipoDev { get; set; }
    }

    public enum TipoDev
    {
        Frontend,
        Backend,
        FullStack,
        Mobile,
        Other
    }
}
