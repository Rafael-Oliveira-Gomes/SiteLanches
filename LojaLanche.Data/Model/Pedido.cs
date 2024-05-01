using LojaLanche.Data.Model.Auth.User;

namespace LojaLanche.Data.Model
{
    public class Pedido
    {
        public required int PedidoId { get; set; }
        public required List<PedidoItem> PedidoItens { get; set; }
        public required ApplicationUser User { get; set; }
    }

    public class PedidoItem
    {
        public required int PedidoItemId { get; set; }
        public required int Quantidade { get; set; }
        public string? Comentario { get; set; }

        public required int PedidoId { get; set; }
        public required Produto Produto { get; set; }
    }
}
