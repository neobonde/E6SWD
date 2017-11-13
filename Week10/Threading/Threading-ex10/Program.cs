using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading_ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            TotalCount tc = new TotalCount();

            Counter c1 = new Counter();
            Counter c2 = new Counter();

            Thread t1 = new Thread(() => c1.StartCounting(tc,200000));
            Thread t2 = new Thread(() => c2.StartCounting(tc,500000));

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            Console.WriteLine(tc.Count);

            //Der er blevet talt op til 563943 og ikke 700000



        }
    }
}
