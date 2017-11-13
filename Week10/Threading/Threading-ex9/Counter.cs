using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading_ex9
{
    class Counter
    {
        public void StartCounting(TotalCount count, int n)
        {
            for (int i = 0; i < n; i++)
            {
                count.Count ++;
            }
        }

    }
}
