using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Threading_ex8;

namespace Threading_ex1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            HelloWriter hw1 = new HelloWriter("Nicolai", 10);
            HelloWriter hw2 = new HelloWriter("Emil", 20 );
            NeverEndingStory n = new NeverEndingStory();

            Thread thread1 = new Thread(hw1.SayHello);
            Thread thread2 = new Thread(hw2.SayHello);
            Thread thread3 = new Thread(n.work);

            thread1.Start();
            thread2.Start();
            thread3.Start();

            thread1.Join();
            thread2.Join();
            var watch = System.Diagnostics.Stopwatch.StartNew();
            n.shallStop = true;
    
            thread3.Join();

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;


            Console.WriteLine("time: " + elapsedMs);
            //It takes a little less then 5 seconds for the program to stop   
        }
    }
}
