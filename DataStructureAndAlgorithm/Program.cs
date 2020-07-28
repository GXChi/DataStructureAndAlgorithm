using System;
using System.Collections.Generic;

namespace DataStructureAndAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            //2,7,3,8,5,1
            var list = new List<int>() { 3, 10, 2, 8, 5 };
   
            Console.WriteLine("********************");
            //Sort.BubbleSort(list);
            //list.SelectionSort();
            //list.InsertionSort();
            list.ShellSort();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
