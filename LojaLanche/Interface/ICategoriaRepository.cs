using LojaLanche.Model;

namespace LojaLanche.Interface
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
