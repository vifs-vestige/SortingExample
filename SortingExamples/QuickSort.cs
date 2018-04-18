using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingExamples
{
    class QuickSort
    {

        public static void Sort(List<int> list)
        {
            Console.WriteLine("Quick Sort");
            Console.WriteLine("");
            Program.PrintList(list);

            Stuff(list, 0, list.Count - 1);

            Program.PrintList(list);
        }

        private static void Stuff(List<int> list, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(list, left, right);

                Stuff(list, left, pivot - 1);
                Stuff(list, pivot + 1, right);
            }
        }

        private static int Partition(List<int> list, int left, int right)
        {
            Console.WriteLine("new pivot from: " + left + "to: " + right);
            int pivot = list[right];
            //int i = left - 1;
            //for (int j = left; j < right; j++)
            //{
            //    Program.PrintCheck(list, j, right);
            //    if(list[j] < pivot)
            //    {
            //        i++;
            //        Program.Swap(list, i, j);
            //    }
            //}
            //Program.Swap(list, i + 1, right);
            //return i + 1;

            int i = right - 1;
            for (int j = left; j < i+1; j++)
            {
                Program.PrintCheck(list, j, right);
                if(list[j] > pivot)
                {
                    while(list[i] > pivot)
                    {
                        Program.PrintCheck(list, i, right);
                        i--;
                        if (i < j)
                        {
                            Program.Swap(list, i + 1, right);
                            return i + 1;
                        }
                    }
                    Program.PrintCheck(list, i, right);
                    Program.Swap(list, i, j);
                }
            }
            Program.Swap(list, i+1, right);
            return i+1;
        }



        

    }
}
