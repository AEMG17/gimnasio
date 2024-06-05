using Gimnasio.Models;

namespace Gimnasio.Services
{
    public interface IConsulta
    {
        Task<List<Consulta>> ConsultasHoy();
        Task<List<Cliente>> Clientes();
        Task<Consulta> AgendarConsulta(Consulta consulta);
        Task BorrarConsulta(int id);
        Task<Consulta> ModificarConsulta(Consulta consulta);
        Task<Consulta> ObtenerConsulta(int id);
    }
}
