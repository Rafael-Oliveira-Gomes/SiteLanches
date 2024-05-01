using LojaLanche.Data.Model.Abstract;

namespace LojaLanche.Data.Model
{
    public class Ingrediente : Item
    {
        public bool IsFresco {  get; set; }
        public DateTime Validade { get; set; }
    }
}
