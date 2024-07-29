using Core.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public class EfRepositoryBase<TEntity, TContext> : IRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext
    {
        protected readonly TContext _dbContext;

        public EfRepositoryBase(TContext dbContext)
        {
                _dbContext = dbContext;
        }


        public void Add(TEntity entity)
        {
           _dbContext.Set<TEntity>().Add(entity);
        }

        public void Delete(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
        }

        public TEntity Get(Expression<Func<TEntity, bool>>? predicate, bool enableTracing = true)
        {
            return _dbContext.Set<TEntity>().FirstOrDefault(predicate);
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>>? predicate = null, bool enableTracing = true)
        {
            if (predicate ==null)
            {
                if (enableTracing == true)
                {
                    return _dbContext.Set<TEntity>().ToList();
                }
                return _dbContext.Set<TEntity>().AsNoTracking().ToList();
            }
            if (enableTracing == true)
            {
                return _dbContext.Set<TEntity>().Where(predicate).ToList(); 
            }
            return _dbContext.Set<TEntity>().Where(predicate).AsNoTracking().ToList();

        }

        public TEntity GetById(int id)
        {
            return _dbContext.Set<TEntity>().SingleOrDefault(e => e.Id == id);
          
        }

        public void Update(TEntity entity)
        {
            _dbContext.Set<TEntity>().Update(entity);
        }
    }
}
