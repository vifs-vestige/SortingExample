using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingExamples
{
    class InsertionSort
    {

        public static void Sort(List<int> list)
        {
            Console.WriteLine("Insertion Sort");
            Console.WriteLine("");
            Program.PrintList(list);
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (list[j - 1] > list[j])
                        Program.Swap(list, j - 1, j);
                    else
                        Program.PrintCheck(list, j - 1, j);
                }
            }
            Program.PrintList(list);
        }
    }
}
