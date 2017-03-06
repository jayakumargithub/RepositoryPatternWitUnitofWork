using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using My.Domain.Interface;
using My.Repositories.Utilities;

namespace My.Repositories.Repos
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class  
    {
        protected readonly DbContext Context;

        public Repository(DbContext context)
        {
            Context = context;
        }
        public void Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            Context.Set<TEntity>().AddRange(entities);
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().Where(predicate);
        }


        //This method help if the id name as EmployeeId, OrderId, BlogId
        public TEntity FindById(int id)
        {
            var lambda = Utilities.Utilities.BuildLambadaForFindByKey<TEntity>(id);
            return Context.Set<TEntity>().AsNoTracking().SingleOrDefault(lambda);
        }

        public TEntity Get(int id)
        {
            return Context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Context.Set<TEntity>().ToList();
        }

        public void Remove(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            Context.Set<TEntity>().RemoveRange(entities);
        }
    }
}
