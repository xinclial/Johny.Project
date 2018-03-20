using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Johny.Project.Data.EF
{
    public interface IDataHelper<T> : IDisposable where T : class
    {
        IQueryable<T> Query(Expression<Func<T, bool>> filter);
    }
}
