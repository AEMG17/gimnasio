using Gimnasio.Models;

namespace Gimnasio.Services
{
    public interface ISuplemento
    {
        Task<Suplemento> RegistrarSuplemento(Suplemento suplemento);
        Task<List<Suplemento>> ListarSuplementos();
    }
}
