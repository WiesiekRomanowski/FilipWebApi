using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Vidly.DataAcces.Interfaces;

namespace Vidly.DataAcces.Repositories
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly VidlyDbContext _context;
        private DbSet<TEntity> _set;

        protected Repository(VidlyDbContext context)
        {
            _context = context;
        }

        public DbSet<TEntity> Set => _set ??= _context.Set<TEntity>();

        public TEntity GetById(int id)
        {
            return Set.Find(id);
        }

        public List<TEntity> GetAll()
        {
            return Set.AsNoTracking().ToList();
        }

        public void Add(TEntity entity)
        {
            Set.Add(entity);
            _context.SaveChanges();
        }

        public void Remove(TEntity entity)
        {
            Set.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            Set.Update(entity);
            _context.SaveChanges();
        }
    }
}
