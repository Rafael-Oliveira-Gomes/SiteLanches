using LojaLanche.Model;

namespace LojaLanche.Interface.Repository
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
