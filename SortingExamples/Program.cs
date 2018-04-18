using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingExamples
{
    class Program
    {
        private static Random RNG;
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            RNG = new Random();
            BubbleSort.Sort(GetList(10));
            Console.ReadLine();
            InsertionSort.Sort(GetList(10));
            Console.ReadLine();
            QuickSort.Sort(GetList(10));
            Console.ReadLine();

        }

        public static List<int> GetList(int size)
        {
            var temp = new List<int>();
            for (int i = 0; i < size; i++)
            {
                temp.Add(RNG.Next(99));
            }
            return temp;
        }

        public static void Swap(List<int> list, int one, int two)
        {
            if (one != two)
            {
                var temp = list[one];
                list[one] = list[two];
                list[two] = temp;
                PrintList(list, one, two);
            }
        }

        public static void PrintCheck(List<int> list, int one, int two)
        {

            for (int i = 0; i < list.Count; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                if (i == one)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                if (i == two)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                Console.Write(list[i] + " ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine("");
        }

        public static void PrintList(List<int> list, int one, int two)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                if (i == one)
                    Console.BackgroundColor = ConsoleColor.Red;
                if (i == two)
                    Console.BackgroundColor = ConsoleColor.Blue;
                Console.Write(list[i] + " ");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            Console.WriteLine("");
        }

        public static void PrintList(List<int> list)
        {
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
