using Microsoft.AspNetCore.Mvc;
using LojaLanche.ViewModel;
using System.Diagnostics;

namespace LojaLanche.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            // Obtém o ID de solicitação de erro do HttpContext
            var requestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;

            // Configura o modelo para sua view de erro
            var errorViewModel = new ErrorViewModel
            {
                RequestId = requestId
            };

            // Retorna a view de erro com o modelo
            return View(errorViewModel);
        }

    }
}
