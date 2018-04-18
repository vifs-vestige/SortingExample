using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingExamples
{
    class BubbleSort
    {

        public static void Sort(List<int> list)
        {
            Console.WriteLine("Bubble Sort");
            Console.WriteLine("");
            Program.PrintList(list);
            for (int i = 0; i < list.Count; i++)
            {
                for (int x = 0; x < list.Count - 1; x++)
                {
                    if (list[x] > list[x + 1])
                        Program.Swap(list, x, x + 1);
                }
            }
            Program.PrintList(list);
            Console.WriteLine("");

        }
    }
}
