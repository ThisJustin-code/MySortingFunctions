/* Justin Gallagher
 * C# Practice
 * 07/10/2021 */

using System;

namespace MySortingFunctions
{
    class MySortingTests
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unsorted Array");

            //Create simple unsorted array
            int[] arr = {1, 5, 7, 3, 4, 9, 2, 6, 8};
            Console.WriteLine("[{0}]", string.Join(", ", arr));
            Console.WriteLine("\n");

            //Run sorting algorithms on the array 
            MySelectionSort.SelectionSort(arr);
            //MyMergeSort.MergeSort(arr);
            //MyInsertionSort.InsertionSort(arr);
            //MyBubbleSort.BubbleSort(arr);
            //MyQuickSort.QuickSort(arr);
        }
    }
}
