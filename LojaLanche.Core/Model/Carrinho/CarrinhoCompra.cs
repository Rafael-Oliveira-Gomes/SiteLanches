namespace LojaLanche.Core.Model.Carrinho
{
    public class CarrinhoCompra
    {
        public string CarrinhoCompraId { get; set; }
        public List<CarrinhoCompraItem> CarrinhoCompraItens { get; set; }
    }
}
