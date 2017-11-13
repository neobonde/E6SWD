using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWriter hw1 = new HelloWriter("Nicolai");
            HelloWriter hw2 = new HelloWriter("Emil");

            Thread thread1 = new Thread(hw1.SayHello);
            Thread thread2 = new Thread(hw2.SayHello);

            thread1.Start();
            thread2.Start();
 
        }
    }
}
