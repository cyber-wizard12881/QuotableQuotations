using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using QuotableQuotations.DomainServices.Interfaces;
using SharpRepository.EfRepository;

namespace QuotableQuotations.DomainServices.Classes
{
    public class GenericRepository<T> : IGenericRepository<T>
        where T : class, new()
    {
        private readonly EfRepository<T> _repository;

        public GenericRepository(DbContext context)
        {
            _repository = new EfRepository<T>(context);
        }

        public IQueryable<T> GetAll()
        {

            IQueryable<T> query = _repository.GetAll().AsQueryable();
            return query;
        }

        public IQueryable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {

            IQueryable<T> query = _repository.FindAll(predicate).AsQueryable();
            return query;
        }

        public T Find(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return _repository.Find(predicate);
        }

        public void Add(T entity)
        {
            _repository.Add(entity);
        }

        public void Delete(T entity)
        {
            _repository.Delete(entity);
        }

        public void Edit(T entity)
        {
            _repository.Update(entity);
        }

        public void Update(IEnumerable<T> entities)
        {
            _repository.Update(entities);
        }

        public void RemoveAll(IEnumerable<T> values)
        {
            _repository.Delete(values);
        }

        public void Insert(IEnumerable<T> values)
        {
            _repository.Add(values);
        }

    }

}
