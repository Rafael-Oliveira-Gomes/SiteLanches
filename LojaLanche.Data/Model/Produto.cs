using LojaLanche.Data.Model.Abstract;
using LojaLanche.Data.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaLanche.Data.Model
{
    public class Produto: Item
    {
        public bool Ativo {  get; set; }
        public TipoEnum Tipo { get; set; }
        public string? Marca { get; set; }
    }
}
