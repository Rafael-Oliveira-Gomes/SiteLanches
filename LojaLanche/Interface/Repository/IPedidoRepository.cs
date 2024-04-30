using LojaLanche.Interface.Repository.Generic;
using LojaLanche.Model;

namespace LojaLanche.Interface.Repository
{
    public interface IPedidoRepository : IGenericRepository<Pedido, int>
    {
        List<Pedido> GetPedidos();
    }
}
