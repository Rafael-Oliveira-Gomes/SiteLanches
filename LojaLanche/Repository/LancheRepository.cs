using LojaLanche.Context;
using LojaLanche.Interface.Repository;
using LojaLanche.Model;
using LojaLanche.Repository.Generic;
using Microsoft.EntityFrameworkCore;

namespace LojaLanche.Repository
{
    public class LancheRepository : GenericRepository<Lanche, int>, ILancheRepository
    {
        private readonly AppDbContext _context;

        public LancheRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c => c.Categoria);
        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches.Where(p => p.IsLanchePreferido).Include(c => c.Categoria);
    }
}