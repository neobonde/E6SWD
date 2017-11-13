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
            /*
            HelloWriter hw1 = new HelloWriter("Nicolai",100);
            HelloWriter hw2 = new HelloWriter("Emil",200);

            Thread thread1 = new Thread(hw1.SayHello);
            Thread thread2 = new Thread(hw2.SayHello);

            thread1.Start();
            thread2.Start();
            */

            //HelloWriter hw1 = new HelloWriter("Nicolai", 100);
            //HelloWriter hw2 = new HelloWriter("Emil", 200);

            //hw1.numberOfTimesToLoop_ = 20;
            //hw2.numberOfTimesToLoop_ = 10;

            //Thread thread1 = new Thread(hw1.SayHello);
            //Thread thread2 = new Thread(hw2.SayHello);

            //thread1.Start();
            //thread2.Start();


            HelloWriter hw1 = new HelloWriter("Nicolai", 100);
            HelloWriter hw2 = new HelloWriter("Emil", 200);

            hw1.Start(30);
            hw2.Start(40);

            Thread thread1 = new Thread(hw1.SayHello);
            Thread thread2 = new Thread(hw2.SayHello);

            thread1.Start();
            thread2.Start();


        }
    }
}
