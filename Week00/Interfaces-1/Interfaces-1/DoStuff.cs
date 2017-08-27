using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_1
{
    class DoStuff
    {
        static void Main(string[] args)
        {
            IDoThings myStuff;

            Console.WriteLine("Press H for DoHickey\nPress D for DoDickey");

            ConsoleKeyInfo input = Console.ReadKey();
            Console.WriteLine("");

            if (char.ToUpper(input.KeyChar) == 'H')
            {
                myStuff = new DoHickey();
            }else if (char.ToUpper(input.KeyChar) == 'D')
            {
                myStuff = new DoDickey();
            }
            else
            {
                Console.WriteLine("Wrong input...\n");
                return;
            }


            myStuff.DoNothing();
            myStuff.DoSomething(4);
            myStuff.DoSomethingElse("Hej");

        }

        interface IDoThings
        {
            void DoNothing();
            int DoSomething(int number);
            string DoSomethingElse(string input);
        }

        class DoHickey : IDoThings
        {
            public void DoNothing()
            {
                Console.WriteLine("DoHickey::DoNothing()");
            }

            public int DoSomething(int number)
            {
                Console.WriteLine("DoHickey::DoSomething(): " + number);
                return number;  
            }

            public string DoSomethingElse(string input)
            {
                Console.WriteLine("DoHickey::DoSomethingElse(): " + input);
                return input;
            }
        }

        class DoDickey : IDoThings
        {
            public void DoNothing()
            {
                Console.WriteLine("DoDickey::DoNothing()");
            }

            public int DoSomething(int number)
            {
                Console.WriteLine("DoDickey::DoNothing()");
                return number;
            }

            public string DoSomethingElse(string input)
            {
                Console.WriteLine("DoDickey::DoNothing()");
                return input;
            }
        }

    }
}
