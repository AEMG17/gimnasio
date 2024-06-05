using Gimnasio.Models;

namespace Gimnasio.Services
{
    public interface ICliente
    {
        Task<Cliente> RegistrarCliente(Cliente cliente);
        Task<List<Cliente>> ListarClientes();
    }
}
