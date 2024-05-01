using LojaLanche.Data.Context;
using LojaLanche.Data.Model;
using LojaLanche.Core.Repository.Generic;
using LojaLanche.Interface.Repository;

namespace LojaLanche.Core.Repository
{
    public class PedidoRepository : GenericRepository<Pedido, int>, IPedidoRepository
    {
        private readonly AppDbContext _context;
        //private readonly CarrinhoCompra _carrinhoCompra;

        public PedidoRepository(AppDbContext context) : base(context)
        {
            _context = context;
            //_carrinhoCompra = carrinhoCompra;
        }

        public List<Pedido> GetPedidos()
        {
            return _context.Pedido.ToList();
        }
    }
}
