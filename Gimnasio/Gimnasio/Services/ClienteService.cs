using Gimnasio.Data;
using Gimnasio.Models;
using Microsoft.EntityFrameworkCore;

namespace Gimnasio.Services
{
    public class ClienteService(ApplicationDbContext context) : ICliente
    {
        public async Task<Cliente> RegistrarCliente(Cliente cliente)
        {
            context.Clientes.Add(cliente);
            await context.SaveChangesAsync();
            return cliente;
        }
        public async Task<List<Cliente>> ListarClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            clientes = await context.Clientes.ToListAsync();
            return clientes;
        }
    }
}
