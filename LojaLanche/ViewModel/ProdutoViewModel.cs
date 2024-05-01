using LojaLanche.Core.Util;
using LojaLanche.Data.Model;

namespace LojaLanche.ViewModel
{
    public class ProdutoViewModel
    {
        public ProdutoViewModel(Produto produto) 
        {
            Descricao = produto.Descricao.ToString();
            Nome = produto.Nome;
            Preco = produto.Preco.ToString("R$x.xx");
            Tipo = produto.Tipo.GetEnumDescription();
        }
        public string? Nome { get; set; }
        public string? Descricao {  get; set; }
        public string? Preco { get; set; }
        public string? Tipo { get; set; }

    }
}
