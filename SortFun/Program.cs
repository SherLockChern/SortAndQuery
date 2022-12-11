using System;
using System.Text;
using SortFun.Sort;

namespace SortFun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            int[] arr1 = new[] { -4, 12, 555, 24, 16, 24, -1, 11 };
            // ISort sortFun = new BubbleSort();
            // ISort sortFun = new SelectionSort();
            // ISort sortFun = new InsertSort();
            // ISort sortFun = new QuickSort();
            ISort sortFun = new MergeSort();
            sortFun.Sort(arr1);
            
        }
    }
}