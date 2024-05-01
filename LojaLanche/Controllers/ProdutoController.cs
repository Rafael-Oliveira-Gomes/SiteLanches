using LojaLanche.Core.Interface.Command;
using LojaLanche.Data.Model;
using LojaLanche.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace LojaLanche.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoCommand _produtoCommand;

        public ProdutoController(IProdutoCommand produtoCommand)
        {
            _produtoCommand = produtoCommand;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var response = await _produtoCommand.GetAllProdutos();

            // Verifica se o status code está no intervalo 200
            if (response.StatusCode < 200 || response.StatusCode >= 300)
            {
                // Se estiver fora do intervalo, redireciona para uma página de erro
                return RedirectToAction("Erro", "Home");
            }

            var viewModel = new List<ProdutoViewModel>();
            foreach (var item in response.Data)
            {
                viewModel.Add(new ProdutoViewModel(item));
            }
            // Se estiver no intervalo, passa os dados para a view
            return View(viewModel);
        }
    }
}
