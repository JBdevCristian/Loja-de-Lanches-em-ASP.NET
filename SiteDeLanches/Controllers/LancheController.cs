using Microsoft.AspNetCore.Mvc;
using SiteDeLanches.Repositories.Interfaces;
using SiteDeLanches.ViewModels;

namespace SiteDeLanches.Controllers
{
    public class LancheController : Controller
    {

        private readonly ILancheRepository _lancheRepository;

        public LancheController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public IActionResult List()
        {
            //var lanches = _lancheRepository.Lanches;
            //return View(lanches);

            var LanchesListViewModel = new LancheListViewModel();
            LanchesListViewModel.Lanches = _lancheRepository.Lanches;
            LanchesListViewModel.CategoriaAtual = "Categoria Atual";

            return View(LanchesListViewModel);
        }
    }
}
