using LojaLanche.Core.Interface.Repository;
using LojaLanche.Core.Interface.Service;
using LojaLanche.Data.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LojaLanche.Core.Service
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _repository;

        public ProdutoService(IProdutoRepository repository)
        {
            _repository = repository;
        }

        public async Task<Produto> CreateProdutoAsync(Produto produto)
        {
            return await _repository.CreateAsync(produto);
        }

        public async Task<bool> DeleteProdutoAsync(int id)
        {
            var produto = await _repository.GetByIdAsync(id);
            if (produto == null)
                return false;

            return await _repository.DeleteAsync(produto);
        }

        public async Task<List<Produto>> GetAllProdutosAsync()
        {
            return await _repository.ListAll().ToListAsync();
        }

        public async Task<Produto> GetProdutoByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<Produto?> UpdateProdutoAsync(Produto produto)
        {
            var existingProduto = await _repository.GetByIdAsync(produto.Id);
            if (existingProduto == null)
                return null;

            existingProduto.Nome = produto.Nome;
            existingProduto.Preco = produto.Preco;
            existingProduto.Tipo = produto.Tipo;
            existingProduto.Ativo = produto.Ativo;

            await _repository.UpdateAsync(existingProduto);
            return existingProduto;
        }
    }
}
