using Johny.Project.Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Johny.Project.Data.EF
{
    public class DataHelper<T> : IDataHelper<T> where T : class
    {
        DataModelEntity context = new DataModelEntity();

        public void Dispose()
        {
            this.context.Dispose();
        }

        public IQueryable<T> Query(Expression<Func<T, bool>> filter)
        {
            return context.Set<T>().Where(filter).AsQueryable();
        }
    }
}
