using LojaLanche.Data.Model;

namespace LojaLanche.ViewModel
{
    public class ProdutoViewModel
    {
        public ProdutoViewModel(Produto produto) 
        {
            Id = produto.Id.ToString();
            Nome = produto.Nome;
            Preco = produto.Preco.ToString("R$x.xx");
        }
        public string? Id {  get; set; }
        public string? Nome { get; set; }
        public string? Preco { get; set; }
    }
}
