using LojaLanche.Core.Interface.Service;
using LojaLanche.Data.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LojaLanche.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : Controller
    {
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpGet("/")]
        public async Task<IActionResult> Index()
        {
            var produtos = await _produtoService.GetAllProdutosAsync();
            return View(produtos);
        }

        [HttpGet]
        public async Task<ActionResult<List<Produto>>> GetAllProdutos()
        {
            var produtos = await _produtoService.GetAllProdutosAsync();
            return Ok(produtos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Produto>> GetProdutoById(int id)
        {
            var produto = await _produtoService.GetProdutoByIdAsync(id);
            if (produto == null)
            {
                return NotFound("Produto não encontrado");
            }
            return Ok(produto);
        }

        [HttpPost]
        public async Task<ActionResult<Produto>> CreateProduto(Produto produto)
        {
            var createdProduto = await _produtoService.CreateProdutoAsync(produto);
            return CreatedAtAction(nameof(GetProdutoById), new { id = createdProduto.Id }, createdProduto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduto(int id, Produto produto)
        {
            if (id != produto.Id)
            {
                return BadRequest("O ID do produto na URL não corresponde ao ID do produto no corpo da solicitação");
            }

            await _produtoService.UpdateProdutoAsync(produto);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduto(int id)
        {
            var existingProduto = await _produtoService.GetProdutoByIdAsync(id);
            if (existingProduto == null)
            {
                return NotFound("Produto não encontrado");
            }

            await _produtoService.DeleteProdutoAsync(id);

            return NoContent();
        }
    }
}
