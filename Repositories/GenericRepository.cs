using Johny.Project.Model.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        internal DataModelEntity context;
        internal DbSet<TEntity> dbSet;

        public GenericRepository(DataModelEntity context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }

        public IEnumerable<TEntity> Get()
        {
            return dbSet.ToList();
        }

        public IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> filter)
        {
            return this.dbSet.Where(filter).AsQueryable();
        }

        public TEntity GetByID(object id)
        {
            return dbSet.Find(id);
        }

        public void Insert(TEntity entity)
        {
            dbSet.Add(entity);
            //context.SaveChanges();
        }

        public void Delete(object id)
        {
            TEntity entity = dbSet.Find(id);
            if (context.Entry(entity).State == EntityState.Deleted)
            {
                dbSet.Attach(entity);
            }
            dbSet.Remove(entity);
            
        }

        public void Update(TEntity entity)
        {
            dbSet.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
        }

        
    }
}
