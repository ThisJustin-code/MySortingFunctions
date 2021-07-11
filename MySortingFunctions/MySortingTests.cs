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
            //Create simple unsorted array
            int[] arr = { 10, 14, 28, 11, 7, 16, 30, 50, 25, 18, 67, 35, 65, 76, 234, 123, 157, 45, 23, 78, 99, 2, 87, 49 };
            Console.WriteLine("Unsorted Array");
            Console.WriteLine("[{0}]", string.Join(", ", arr));

            //Create test arrays
            int[] selectionTestArray = new int[arr.Length];
            int[] insertionTestArray = new int[arr.Length];
            int[] bubbleTestArray = new int[arr.Length];
            int[] mergeTestArray = new int[arr.Length];
            int[] quickTestArray = new int[arr.Length];

            //Copy original array into test arrays
            arr.CopyTo(selectionTestArray, 0);
            arr.CopyTo(insertionTestArray, 0);
            arr.CopyTo(bubbleTestArray, 0);
            arr.CopyTo(mergeTestArray, 0);
            arr.CopyTo(quickTestArray, 0);

            //Run sorting algorithms on the array and print test results
            MySelectionSort.SelectionSort(selectionTestArray);
            Console.WriteLine("Selection Sort");
            Console.WriteLine("[{0}]", string.Join(", ", selectionTestArray));

            MyInsertionSort.InsertionSort(insertionTestArray);
            Console.WriteLine("Insertion Sort");
            Console.WriteLine("[{0}]", string.Join(", ", insertionTestArray));

            MyBubbleSort.BubbleSort(bubbleTestArray);
            Console.WriteLine("Bubble Sort");
            Console.WriteLine("[{0}]", string.Join(", ", bubbleTestArray));

            MyMergeSort.MergeSort(mergeTestArray, 0, mergeTestArray.Length - 1);
            Console.WriteLine("Merge Sort");
            Console.WriteLine("[{0}]", string.Join(", ", mergeTestArray));

            MyQuickSort.QuickSort(quickTestArray, 0, quickTestArray.Length - 1);
            Console.WriteLine("Quick Sort");
            Console.WriteLine("[{0}]", string.Join(", ", quickTestArray));
        }
    }
}
