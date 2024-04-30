using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using LojaLanche.Interface.Repository.Generic;
using LojaLanche.Core.Context;

namespace LojaLanche.Core.Repository.Generic
{
    public class GenericRepository<T, TKey> : IGenericRepository<T, TKey> where T : class where TKey : struct
    {
        private readonly AppDbContext _context;

        protected GenericRepository(AppDbContext context)
        {
            _context = context;
        }

        public virtual async Task<T> CreateAsync(T entity)
        {
            EntityEntry<T> ret = await _context.Set<T>().AddAsync(entity);

            await _context.SaveChangesAsync();

            ret.State = EntityState.Detached;

            return ret.Entity;
        }

        public virtual async Task<int> UpdateAsync(T entity)
        {
            EntityEntry<T>? entry = _context.Entry(entity);

            if (entry == null) throw new KeyNotFoundException("Entidade não encontrada");

            entry.State = EntityState.Modified;

            return await _context.SaveChangesAsync();

        }

        public virtual async Task<int> InsertOrUpdateAsync(T entity)
        {
            _context.Update(entity);
            return await _context.SaveChangesAsync();
        }

        public virtual async Task<bool> DeleteAsync(T entity)
        {
            EntityEntry<T>? entry = _context.Entry(entity);

            if (entry == null) throw new KeyNotFoundException("Entidade não encontrada");

            entry.State = EntityState.Deleted;
            await _context.SaveChangesAsync();

            return true;

        }

        public virtual T GetById(TKey id)
        {
            return _context.Set<T>().Find(id)!;
        }

        public virtual async Task<T> GetByIdAsync(TKey id)
        {
            return (await _context.Set<T>().FindAsync(id))!;
        }

        public virtual IQueryable<T> Query()
        {
            return _context.Set<T>().AsNoTracking();
        }
    }
}