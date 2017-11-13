using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading_ex8
{
    class NeverEndingStory
    {
        public bool shallStop { get; set; }

        public void work()
        {
            while (!shallStop)
            {
                Console.WriteLine("Never Ending Story");
                Thread.Sleep(5000);
            }
        }
    }
}
