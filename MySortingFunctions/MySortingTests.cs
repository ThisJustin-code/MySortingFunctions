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
            int[] arr1 = { 1, 5, 7, 3, 4, 9, 2, 6, 8 };
            int[] arr2 = { 1, 5, 7, 3, 4, 9, 2, 6, 8 };
            int[] arr3 = { 1, 5, 7, 3, 4, 9, 2, 6, 8 };
            int[] arr4 = { 1, 5, 7, 3, 4, 9, 2, 6, 8 };
            int[] arr5 = { 1, 5, 7, 3, 4, 9, 2, 6, 8 };
            Console.WriteLine("[{0}]", string.Join(", ", arr1));
            Console.WriteLine("\n");

            //Run sorting algorithms on the array 
            MySelectionSort.SelectionSort(arr1);
            MyInsertionSort.InsertionSort(arr2);
            MyBubbleSort.BubbleSort(arr3);
            //MyMergeSort.MergeSort(arr4);
            //MyQuickSort.QuickSort(arr5);
        }
    }
}
