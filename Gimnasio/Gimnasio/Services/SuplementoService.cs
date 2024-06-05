using Gimnasio.Data;
using Gimnasio.Models;
using Microsoft.EntityFrameworkCore;

namespace Gimnasio.Services
{
    public class SuplementoService(ApplicationDbContext context) : ISuplemento
    {
        public async Task<Suplemento> RegistrarSuplemento(Suplemento suplemento)
        {
            context.Suplementos.Add(suplemento);
            await context.SaveChangesAsync();
            return suplemento;
        }
        public async Task<List<Suplemento>> ListarSuplementos()
        {
            List<Suplemento> suplementos = new List<Suplemento>();
            suplementos = await context.Suplementos.ToListAsync();
            return suplementos;
        }
    }
}
