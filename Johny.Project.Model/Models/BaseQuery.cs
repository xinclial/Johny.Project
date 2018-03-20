using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Johny.Project.Model.Models
{
    public class BaseQuery
    {
        
        public int rows { set; get; }

        public int page { set; get; }

        public int SessionID;

        public int GetSkipCount()
        {
            return (page - 1) * rows;
        }
    }
}
