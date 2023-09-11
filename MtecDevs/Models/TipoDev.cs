using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MtecDevs.Models

[Tables("TipoDev")]

    public class TipoDev
    {
        [Key]
        public int Id {get; set; }
        
        [Required(ErrorMessage = "Informe o Nome")]
        [StringLength(30, ErrorMessage = "O nome deve possuir no máximo 30 caracteres")] 
        public string Nome {get; set; }       
    }
