using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using SalesWebMvc.Models;
using SalesWebMvc.Models.ViewModel;
using SalesWebMvc.Services;
using SalesWebMvc.Services.Exceptions;
using System.Diagnostics;

namespace SalesWebMvc.Controllers
{
    public class VendedoresController : Controller
    {
        private readonly VendedorService _vendedorServico;
        private readonly DepartamentoService _departamentoService;

        public VendedoresController(VendedorService vendedorServico, DepartamentoService departamentoService)
        {
            _vendedorServico = vendedorServico;
            _departamentoService = departamentoService;
        }

        public IActionResult Index()
        {
            var list = _vendedorServico.FindAll();

            return View(list);
        }

        public IActionResult Criar()
        {
            var departamentos = _departamentoService.FindAll();
            var viewModel = new VendedorFormViewModel { Departamentos = departamentos };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Criar(Vendedor vendedor)
        {
            _vendedorServico.Inserir(vendedor);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Deletar(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não fornecido"});
            }

            var vendededor = _vendedorServico.GetById(id.Value);

            if (vendededor == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não encontrado" });
            }
            return View(vendededor);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Deletar(int id)
        { 
            _vendedorServico.Delete(id);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Detalhar(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não fornecido" });
            }

            var vendededor = _vendedorServico.GetById(id.Value);

            if (vendededor == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não encontrado" });
            }
            return View(vendededor);
        }

        public IActionResult Editar(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não fornecido" });
            }

            var vendededor = _vendedorServico.GetById(id.Value);

            if (vendededor == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não encontrado" });
            }

            List<Departamento> departamentos = _departamentoService.FindAll();
            VendedorFormViewModel viewModel = new VendedorFormViewModel { Vendedor = vendededor, Departamentos = departamentos };
            
            return View(viewModel);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar(int id, Vendedor vendedor)
        {
            if (id != vendedor.Id)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não corresponde" });
            }

            try
            {
                _vendedorServico.Update(vendedor);
                return RedirectToAction(nameof(Index));
            }
            catch (NotFoundException exception)
            {
                return RedirectToAction(nameof(Error), new { message = exception.Message });
            }
            catch (DbConcurrencyException exception)
            {
                return RedirectToAction(nameof(Error), new { message = exception.Message });
            }            
        }

        public IActionResult Error(string message)
        {
            var viewModel = new ErrorViewModel
            {
                Message = message,
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };

            return View(viewModel);
        }
    }
}
