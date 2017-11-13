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
        public static void NeverEndingStory()
        {
            while (true)
            {
                Console.WriteLine("Never Ending Story");
                Thread.Sleep(5000);
            }
        }

        static void Main(string[] args)
        {

            HelloWriter hw1 = new HelloWriter("Nicolai", 10);
            HelloWriter hw2 = new HelloWriter("Emil", 20 );
            HelloWriter hw3 = new HelloWriter("", 20);

            Thread thread1 = new Thread(hw1.SayHello);
            Thread thread2 = new Thread(hw2.SayHello);
            Thread thread3 = new Thread(NeverEndingStory);

            thread1.Start();
            thread2.Start();
            thread3.Start();

            thread1.Join();
            thread2.Join();
            thread3.Join();

            //It writes a never ending story to begin with and then it writes all the hello's where after it writes never endings story every 5 seconds
        }
    }
}
