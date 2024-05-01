using LojaLanche.Core.Model.Enum;
using LojaLanche.Core.Util;

namespace LojaLanche.Core.Model.Abstract
{
    internal abstract class Item
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public TipeEnum Tipo { get; set; }
        public string? TipoDescricao => this.Tipo.GetEnumDescription();
        public string? Marca { get; set; }
        public int QuantidadeEstoque { get; set; }
    }
}
