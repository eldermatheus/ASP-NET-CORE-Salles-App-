using Microsoft.EntityFrameworkCore;
using NuGet.Protocol;
using SalesWebMvc.Models;
using SalesWebMvc.Services.Exceptions;

namespace SalesWebMvc.Services
{
    public class VendedorService
    {
        private readonly SalesWebMvcContext _context;

        public VendedorService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Vendedor> FindAll()
        {
            return _context.Vendedor.ToList();
        }

        public void Inserir(Vendedor vendedor)
        {
            _context.Add(vendedor);
            _context.SaveChanges();
        }

        public Vendedor GetById(int id)
        {
            return _context.Vendedor.Include(obj => obj.Departamento).FirstOrDefault(vendedor => vendedor.Id == id);
        }

        public void Delete(int id)
        {
            var vendedor = _context.Vendedor.Find(id);
            _context.Vendedor.Remove(vendedor);
            _context.SaveChanges();
        }

        public void Update(Vendedor vendedor)
        { 
            if (!_context.Vendedor.Any(x => x.Id == vendedor.Id)) 
            {
                throw new NotFoundException("Id não encontrada");
            }

            try
            {
                _context.Update(vendedor);
                _context.SaveChanges();
            }
            catch (DbConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }            
        }
    }
}