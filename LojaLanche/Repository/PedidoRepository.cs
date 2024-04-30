using LojaLanche.Context;
using LojaLanche.Interface.Repository;
using LojaLanche.Model;
using LojaLanche.Repository.Generic;

namespace LojaLanche.Repository
{
    public class PedidoRepository : GenericRepository<Pedido, int>, IPedidoRepository
    {
        private readonly AppDbContext _context;
        //private readonly CarrinhoCompra _carrinhoCompra;

        public PedidoRepository(AppDbContext context, CarrinhoCompra carrinhoCompra): base(context)
        {
            _context = context;
            //_carrinhoCompra = carrinhoCompra;
        }

        public List<Pedido> GetPedidos()
        {
            return _context.Pedidos.ToList();
        }

        //public void CriarPedido(Pedido pedido)
        //{
        //    pedido.PedidoEnviado = DateTime.Now;
        //    //pedido.PedidoEntregueEm = DateTime.Now;

        //    _context.Pedidos.Add(pedido);
        //    _context.SaveChanges();

        //    //var carrinhoCompraItens = _carrinhoCompra.CarrinhoCompraItens;

        //    //foreach (var carrinhoItem in carrinhoCompraItens)
        //    //{
        //    //    var pedidoDetail = new PedidoDetalhe()
        //    //    {
        //    //        Quantidade = carrinhoItem.Quantidade,
        //    //        LancheId = carrinhoItem.Lanche.LancheId,
        //    //        PedidoId = pedido.PedidoId,
        //    //        Preco = carrinhoItem.Lanche.Preco
        //    //    };
        //    //    _appDbContext.PedidoDetalhes.Add(pedidoDetail);
        //    //}
        //    //_appDbContext.SaveChanges();
        //}
    }
}
