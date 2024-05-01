using System.ComponentModel;

namespace LojaLanche.Core.Model.Enum
{
    internal enum TipeEnum
    {
        [Description("None")]
        None = 0,
        [Description("Ingrediente")]
        Ingrediente = 1,
        [Description("Bebida")]
        Bebida = 2,
        [Description("Prato")]
        Prato = 3
    }
}
