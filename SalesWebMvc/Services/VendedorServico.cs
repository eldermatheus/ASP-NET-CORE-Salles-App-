using SalesWebMvc.Models;

namespace SalesWebMvc.Services
{
    public class VendedorServico
    {
        private readonly SalesWebMvcContext _context;

        public VendedorServico( SalesWebMvcContext context)
        { 
            _context = context;
        }

        public List<Vendedor> FindAll() 
        { 
            return _context.Vendedor.ToList();
        }

    }
}
