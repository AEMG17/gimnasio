using System.ComponentModel.DataAnnotations;

namespace Gimnasio.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del cliente es requerido")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El primer apellido del cliente es requerido")]
        public string PrimerApellido { get; set; }

        public string? SegundoApellido { get; set; }

        [Required(ErrorMessage = "La {0} del cliente es requerida")]
        [MinLength(18, ErrorMessage = "La {0} debe de tener {1} caracteres")]
        [MaxLength(18, ErrorMessage = "La {0} debe de tener {1} caracteres")]
        public string CURP { get; set; }
        public string? Observaciones { get; set; }
    }
}
