using Gimnasio.Components.Pages;
using Gimnasio.Data;
using Gimnasio.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace Gimnasio.Services
{
    public class ConsultaService (ApplicationDbContext context) : IConsulta
    {
        public async Task<List<Consulta>> ConsultasHoy()
        {
            List<Consulta> consultas = new List<Consulta>();
            consultas = await context.Consultas.Include(c => c.Cliente)
                .OrderBy(f => f.Fecha).ToListAsync();
            return consultas;
        }
        public async Task<List<Cliente>> Clientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            clientes = await context.Clientes.ToListAsync();
            return clientes;
        }
        public async Task<Consulta> AgendarConsulta(Consulta consulta)
        {
           var respuesta = context.Consultas.Add(consulta);
            await context.SaveChangesAsync();
            return consulta;
        }
        public async Task BorrarConsulta(int id)
        {
            var consulta = await context.Consultas.FindAsync(id);
            if (consulta != null)
            {
                context.Consultas.Remove(consulta);
                await context.SaveChangesAsync();
            }
        }
        public async Task<Consulta> ModificarConsulta(Consulta consulta)
        {
            context.Consultas.Update(consulta);
            await context.SaveChangesAsync();
            return consulta;
        }

        public async Task<Consulta> ObtenerConsulta(int id)
        {
            var consulta = await context.Consultas.FindAsync(id);
            return consulta;
        }

    }
}