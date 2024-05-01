using LojaLanche.Data.Model;

namespace LojaLanche.Core.Interface.Service
{
    public interface IProdutoService
    {
        Task<List<Produto>> GetAllProdutosAsync();
        Task<Produto> GetProdutoByIdAsync(int id);
        Task<Produto> CreateProdutoAsync(Produto produto);
        Task<Produto?> UpdateProdutoAsync(Produto produto);
        Task<bool> DeleteProdutoAsync(int id);
    }
}
