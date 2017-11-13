using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading_ex11
{
    class Program
    {
        private static object totalCardsLock = new object();
        private static object totalSumOfSpadesLock = new object();
        private static object totalAmoutOfAcesLock = new object();

        private static int totalCards = 0;
        private static int totalSumOfSpades = 0;
        private static int totalAmoutOfAces = 0;

        public static List<Tuple<String, int>> parseFile(string path)
        {
            List<Tuple<String, int>> cards_list = new List<Tuple<String, int>>();
            string cards = System.IO.File.ReadAllText(path);

            string[] cardSplit = cards.Split(
                new[] {"\n"},
                StringSplitOptions.None
            );

            foreach (var card in cardSplit)
            {
                string[] split = card.Split(
                    new[] {","},
                    StringSplitOptions.None
                );
                if (split[0] != "")
                {
                    cards_list.Add(new Tuple<string, int>(split[0], Int32.Parse(split[1])));
                    //cards1_list.Add(new Tuple<string,int>(split[0],Int32.Parse(split[1])));
                }
            }

            return cards_list;
        }

        public static void Count(object path)
        {
            var cards = parseFile((string)path);

            lock (totalCardsLock)
            {
                totalCards += cards.Count;
            }

            foreach (var tuple in cards)
            {
                if (tuple.Item1 == "SPADE")
                {
                    lock (totalSumOfSpadesLock)
                    {
                        totalSumOfSpades += tuple.Item2;
                    }
                }
                if (tuple.Item2 == 1)
                {
                    lock (totalAmoutOfAcesLock)
                    {
                        totalAmoutOfAces++;
                    }
                }
            }
        }


        static void Main(string[] args)
        {
            Stopwatch stopWatch1 = new Stopwatch();
            stopWatch1.Start();

            var cards1 = parseFile(@"../../Cards/cards.txt");
            var cards2 = parseFile(@"../../Cards/cards2.txt");
            var cards3 = parseFile(@"../../Cards/cards3.txt");

            foreach (var tuple in cards1)
            {
                if (tuple.Item1 == "SPADE")
                {
                    totalSumOfSpades += tuple.Item2;
                }
                if (tuple.Item2 == 1)
                {
                    totalAmoutOfAces++;
                }
            }
            foreach (var tuple in cards2)
            {
                if (tuple.Item1 == "SPADE")
                {
                    totalSumOfSpades += tuple.Item2;
                }
                if (tuple.Item2 == 1)
                {
                    totalAmoutOfAces++;
                }
            }
            foreach (var tuple in cards3)
            {
                if (tuple.Item1 == "SPADE")
                {
                    totalSumOfSpades += tuple.Item2;
                }
                if (tuple.Item2 == 1)
                {
                    totalAmoutOfAces++;
                }
            }
            stopWatch1.Stop();

            totalCards = cards1.Count + cards2.Count + cards3.Count;
            Console.WriteLine("------- Sequential --------------\n\n");
            Console.WriteLine("Total Cards: " + totalCards);
            Console.WriteLine("Sum of Spaces: " + totalSumOfSpades);
            Console.WriteLine("Total amout of aces: " + totalAmoutOfAces);
            Console.WriteLine("\nIt took " + stopWatch1.Elapsed.TotalSeconds + "s");
            totalAmoutOfAces = 0;
            totalCards = 0;
            totalSumOfSpades = 0;

            Console.WriteLine("------- Parallel --------------\n\n");
            Stopwatch stopWatch2 = new Stopwatch();
            stopWatch2.Start();

            ThreadPool.QueueUserWorkItem(Count, @"../../Cards/cards.txt");
            ThreadPool.QueueUserWorkItem(Count, @"../../Cards/cards2.txt");
            ThreadPool.QueueUserWorkItem(Count, @"../../Cards/cards3.txt");

            Thread.Sleep(10000);
            stopWatch2.Stop();

            Console.WriteLine("Total Cards: " + totalCards);
            Console.WriteLine("Sum of Spaces: " + totalSumOfSpades);
            Console.WriteLine("Total amout of aces: " + totalAmoutOfAces);
            Console.WriteLine("\nIt took " + stopWatch2.Elapsed.TotalSeconds + "s");

            /* Final output:
            ------- Sequential --------------


            Total Cards: 5165064
            Sum of Spaces: 9358056
            Total amout of aces: 195408

            It took 8.3386904s
            ------- Parallel --------------


            Total Cards: 5165064
            Sum of Spaces: 9358056
            Total amout of aces: 195408

            It took 7.933232s
            */
        }
    }
}