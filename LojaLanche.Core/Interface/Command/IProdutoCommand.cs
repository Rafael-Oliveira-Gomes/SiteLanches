using LojaLanche.Data.Model;

namespace LojaLanche.Core.Interface.Command
{
    public interface IProdutoCommand
    {
        Task<ResponseCommon<Produto>> CreateProduto(Produto produto);
        Task<ResponseCommon<bool>> DeleteProduto(int id);
        Task<ResponseCommon<List<Produto>>> GetAllProdutos();
        Task<ResponseCommon<Produto>> GetProdutoById(int id);
        Task<ResponseCommon<Produto?>> UpdateProduto(int id, Produto produto);
    }
}