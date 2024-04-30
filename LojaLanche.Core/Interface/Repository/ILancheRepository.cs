using LojaLanche.Core.Model;
using LojaLanche.Interface.Repository.Generic;

namespace LojaLanche.Interface.Repository
{
    public interface ILancheRepository: IGenericRepository<Lanche, int>
    {
        IEnumerable<Lanche> Lanches { get; }
        IEnumerable<Lanche> LanchesPreferidos { get; }
    }
}
