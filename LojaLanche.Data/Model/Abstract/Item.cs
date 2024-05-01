
namespace LojaLanche.Data.Model.Abstract
{
    public abstract class Item
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public string? Descricao { get; set; }
        public int QuantidadeEstoque { get; set; }
        public string? Imagem { get; set; }
    }
}
