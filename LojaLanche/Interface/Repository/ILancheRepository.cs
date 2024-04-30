using LojaLanche.Interface.Repository.Generic;
using LojaLanche.Model;

namespace LojaLanche.Interface.Repository
{
    public interface ILancheRepository: IGenericRepository<Lanche, int>
    {
        IEnumerable<Lanche> Lanches { get; }
        IEnumerable<Lanche> LanchesPreferidos { get; }
    }
}
