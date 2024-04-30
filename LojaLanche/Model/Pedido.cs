namespace LojaLanche.Model
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public virtual List<PedidoDetalhe> PedidoItens { get; set; }
        public string Nome { get; set; }
        public decimal PedidoTotal { get; set; }
        public DateTime PedidoEnviado { get; set; }
        public int TotalItensPedido { get; set; }
        public int MesaPedido { get; set; }
    }
}
