using LojaLanche.Core.Interface.Repository;
using LojaLanche.Core.Interface.Service;
using LojaLanche.Data.Model;

namespace LojaLanche.Core.Service
{
    public class ProdutoService : IProdutoService
    {
        private IProdutoRepository _repository;
        public ProdutoService(IProdutoRepository repository) 
        {
            _repository = repository;
        }
        public async Task<Produto> CreateProdutoAsync(Produto produto)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteProdutoAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Produto>> GetAllProdutosAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Produto> GetProdutoByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Produto> UpdateProdutoAsync(Produto produto)
        {
            throw new NotImplementedException();
        }
    }
}
