using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Models;

namespace SalesWebMvc.Services
{
    public class VendasService
    {
        private readonly SalesWebMvcContext _context;
        public VendasService(SalesWebMvcContext context)
        { 
            _context = context;
        }

        public async Task<List<Vendas>> GetVendasAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = await _context.Vendas
                .Where(venda => venda.Data >= minDate && venda.Data <= maxDate)
                .Include(x => x.Vendedor)
                .Include(x => x.Vendedor.Departamento)
                .OrderByDescending(x => x.Data)
                .ToListAsync();

            return result;

            /*var result = from obj in _context.Vendas select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Data >= minDate.Value);
            }

            if (maxDate.HasValue) 
            {
                result = result.Where(x => x.Data <= maxDate.Value);
            }

            return await result
                .Include(x => x.Vendedor)
                .Include(x => x.Vendedor.Departamento)
                .OrderByDescending(x => x.Data)
                .ToListAsync();*/
        }
    }
}