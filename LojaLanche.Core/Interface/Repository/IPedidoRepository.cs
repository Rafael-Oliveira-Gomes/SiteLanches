using LojaLanche.Data.Model;
using LojaLanche.Interface.Repository.Generic;

namespace LojaLanche.Interface.Repository
{
    public interface IPedidoRepository : IGenericRepository<Pedido, int>
    {
        List<Pedido> GetPedidos();
    }
}
