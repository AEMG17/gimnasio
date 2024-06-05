using System.ComponentModel.DataAnnotations;

namespace Gimnasio.Models
{
    public class Suplemento
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre del suplemento es requerido")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "El precio del suplemento es requerido")]
        public float Precio { get; set; } = 0.0f;
        public int Stock { get; set; } = 0;
        public string? Categoria { get; set; }
    }
}
