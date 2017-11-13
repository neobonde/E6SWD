﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading_ex1
{
    public class HelloWriter
    {
        public string name_;
        public int numberOfTimesToLoop_;
        public int sleep_time_;

        public HelloWriter(string name, int numberOfTimesToLoop, int sleep_time)
        {
            name_ = name;
            numberOfTimesToLoop_ = numberOfTimesToLoop;
            sleep_time_ = sleep_time;
        }

        public void Start(int numberOfTimesToLoop)
        {
            numberOfTimesToLoop_ = numberOfTimesToLoop;
        }

        public void SayHello()
        {
            for (int i = 0; i < numberOfTimesToLoop_; i++)
            {
                Console.WriteLine("Hello from " + name_ + " #" + i);
                Thread.Sleep(sleep_time_);
            }
        }
    }
}