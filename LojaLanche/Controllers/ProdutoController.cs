using LojaLanche.Core.Interface.Command;
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

        [HttpGet("/")]
        public async Task<IActionResult> Index()
        {
            var produtos = await _produtoCommand.GetAllProdutos();
            return View(produtos);
        }        
    }
}
