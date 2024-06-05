using System.ComponentModel.DataAnnotations;

namespace Gimnasio.Models
{
    public class Consulta
    {
        public int Id { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Favor de elegir al cliente")]
        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; }
        public DateTime? Fecha { get; set; }
        public string? Observaciones { get; set; }

        ICollection<Cliente> Clientes { get; set; }
    }
}
