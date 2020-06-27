using Core.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected AppDbContext Context;
        public Repository(AppDbContext _Context)
        {
            Context = _Context;
        }
        void IRepository<TEntity>.Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
        }

        bool IRepository<TEntity>.Any(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        int IRepository<TEntity>.Count(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        void IRepository<TEntity>.Edit(TEntity entity)
        {
            throw new NotImplementedException();
        }

        IEnumerable<TEntity> IRepository<TEntity>.Find(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        TEntity IRepository<TEntity>.Get(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<TEntity> IRepository<TEntity>.GetAll()
        {
            return Context.Set<TEntity>().ToList();
        }

        void IRepository<TEntity>.Remove(TEntity entity)
        {
             Context.Set<TEntity>().Remove(entity);
        }

        TEntity IRepository<TEntity>.SingleOrDefault(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().SingleOrDefault(predicate);
        }

        IEnumerable<TEntity> IRepository<TEntity>.Take(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate, System.Linq.Expressions.Expression<Func<TEntity, int>> order, int pageSize, int pageNumber)
        {
            throw new NotImplementedException();
        }
    }
}
