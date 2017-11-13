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

            HelloWriter hw1 = new HelloWriter("Nicolai", 10);
            HelloWriter hw2 = new HelloWriter("Emil", 20 );

            Thread thread1 = new Thread(hw1.SayHello);
            Thread thread2 = new Thread(hw2.SayHello);

            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();

            Console.WriteLine("Hello from main");

            //it writes hello from main to begin with.
        }
    }
}
