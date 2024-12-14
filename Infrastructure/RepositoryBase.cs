using Application;
using Domain;
using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Infrastructure
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly NorthwindEntities _entities;
        private readonly DbSet<T> _db;

        public RepositoryBase(
            NorthwindEntities entities
            )
        {
            _entities = entities;
            _db = entities.Set<T>();
        }

        public int Create(T entity)
        {
            _db.Add(entity);
            return _entities.SaveChanges();
        }

        public void Delete(T entity)
        {
            if (_entities.Entry(entity).State == EntityState.Detached)
            {
                _db.Attach(entity);
            }
            _db.Remove(entity);
            _entities.SaveChanges();
        }

        public IQueryable<T> Get(Expression<Func<T, bool>> expression)
        {
            return _db.AsNoTracking().Where( expression );
        }

        public IQueryable<T> GetAll()
        {
            return _db.AsNoTracking();
        }

        public bool Update(T entity)
        {
            _db.Attach(entity);
            _entities.Entry(entity).State = EntityState.Modified;
            return _entities.SaveChanges() >= 1;
        }
    }
}
