﻿using System.ComponentModel;

namespace LojaLanche.Data.Model.Enum
{
    public enum TipoEnum
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
