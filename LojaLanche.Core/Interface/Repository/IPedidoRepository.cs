using LojaLanche.Core.Model.Pedido;
using LojaLanche.Interface.Repository.Generic;

namespace LojaLanche.Interface.Repository
{
    public interface IPedidoRepository : IGenericRepository<Pedido, int>
    {
        List<Pedido> GetPedidos();
    }
}
