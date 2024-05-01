using LojaLanche.Data.Context;
using LojaLanche.Core.Interface.Repository;
using LojaLanche.Data.Model;
using LojaLanche.Core.Repository.Generic;
using Microsoft.EntityFrameworkCore;

namespace LojaLanche.Core.Repository
{
    public class ProdutoRepository : GenericRepository<Produto, int>, IProdutoRepository
    {
        private readonly AppDbContext _context;

        public ProdutoRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

    }
}