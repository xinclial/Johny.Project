using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> Get();

        IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> filter);

        TEntity GetByID(object id);

        void Insert(TEntity entity);
        void Delete(object id);
        void Update(TEntity entity);
        
    }
}
