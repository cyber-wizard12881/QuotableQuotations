using System;
using System.Collections.Generic;
using System.Linq;

namespace QuotableQuotations.DomainServices.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        IQueryable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate);
        T Find(System.Linq.Expressions.Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Delete(T entity);
        void Edit(T entity);
        void Update(IEnumerable<T> entities);
        void RemoveAll(IEnumerable<T> values);
        void Insert(IEnumerable<T> values);
    }
}
