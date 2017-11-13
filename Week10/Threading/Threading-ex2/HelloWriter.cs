using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading_ex1
{
    public class HelloWriter
    {
        public string name_;

        public HelloWriter(string name)
        {
            name_ = name;
        }

        public void SayHello()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Hello from " + name_ + " #" + i);
            }
        }
    }
}
