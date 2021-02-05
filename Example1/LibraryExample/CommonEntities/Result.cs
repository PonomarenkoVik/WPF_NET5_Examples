using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonEntities
{
    public class Result<R, V>
    {
        public Result(R res, V val)
        {
            DialogResult = res;
            ReturnValue = val;
        }

        public R DialogResult { get;  }
        public V ReturnValue { get; }
    }
}
