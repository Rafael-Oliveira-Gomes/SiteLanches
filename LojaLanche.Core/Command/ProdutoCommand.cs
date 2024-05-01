using LojaLanche.Core.Interface.Command;
using LojaLanche.Core.Interface.Service;
using LojaLanche.Data.Model;

namespace LojaLanche.Core.Command
{
    public class ProdutoCommand : IProdutoCommand
    {
        private readonly IProdutoService _produtoService;

        public ProdutoCommand(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        public async Task<ResponseCommon<List<Produto>>> GetAllProdutos()
        {
            var produtos = await _produtoService.GetAllProdutosAsync();
            return ResponseCommon<List<Produto>>.Sucesso(produtos);
        }

        public async Task<ResponseCommon<Produto>> GetProdutoById(int id)
        {
            var produto = await _produtoService.GetProdutoByIdAsync(id);
            if (produto == null)
            {
                return ResponseCommon<Produto>.Falha("Produto não encontrado", 404);
            }
            return ResponseCommon<Produto>.Sucesso(produto);
        }

        public async Task<ResponseCommon<Produto>> CreateProduto(Produto produto)
        {
            var createdProduto = await _produtoService.CreateProdutoAsync(produto);
            return await GetProdutoById(createdProduto.Id);
        }

        public async Task<ResponseCommon<Produto?>> UpdateProduto(int id, Produto produto)
        {
            if (id != produto.Id)
            {
                return ResponseCommon<Produto?>.Falha("O ID do produto na URL não corresponde ao ID do produto no corpo da solicitação", 400);
            }

            var result = await _produtoService.UpdateProdutoAsync(produto);

            return ResponseCommon<Produto?>.Sucesso(result);
        }

        public async Task<ResponseCommon<bool>> DeleteProduto(int id)
        {
            var existingProduto = await _produtoService.GetProdutoByIdAsync(id);
            if (existingProduto == null)
            {
                return ResponseCommon<bool>.Falha("Produto não encontrado", 404);
            }

            var result = await _produtoService.DeleteProdutoAsync(id);

            return ResponseCommon<bool>.Sucesso(true);
        }
    }
}
