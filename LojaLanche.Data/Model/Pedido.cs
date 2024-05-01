using LojaLanche.Data.Model.Auth.User;

namespace LojaLanche.Data.Model
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public List<PedidoItem> PedidoItens { get; set; }
        public ApplicationUser User { get; set; }
    }

    public class PedidoItem
    {
        public int PedidoItemId { get; set; }
        public int Quantidade { get; set; }
        public string Comentario { get; set; }

        public int PedidoId { get; set; }
        public Produto Produto { get; set; }
    }
}
