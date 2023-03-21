using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Models.ViewModel;
using SalesWebMvc.Services;

namespace SalesWebMvc.Controllers
{
    public class VendedoresController : Controller
    {
        private readonly VendedorService _vendedorServico;
        private readonly DepartamentoService _departamentoService;

        public VendedoresController(VendedorService vendedorServico, DepartamentoService departamentoService)
        {
            _vendedorServico = vendedorServico;
            _departamentoService= departamentoService;
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
    }
}
