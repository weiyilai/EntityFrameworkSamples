using System;
using System.Linq;
using System.Linq.Expressions;

namespace Application
{
    public interface IRepositoryBase<T> where T : class
    {
        IQueryable<T> GetAll();
        IQueryable<T> Get(Expression<Func<T, bool>> expression);
        int Create(T entity);
        bool Update(T entity);
        void Delete(T entity);
    }
}
