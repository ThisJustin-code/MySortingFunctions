using System;

namespace MySortingFunctions
{
    class MySortingTests
    {
        static void Main(string[] args)
        {
            //Create simple unsorted array
            int[] arr = {1, 5, 7, 3, 4, 9, 2, 6, 8};

            //Run sorting algorithms on the array 
            MySelectionSort.SelectionSort(arr);
            MyMergeSort.MergeSort(arr);
            MyInsertionSort.InsertionSort(arr);
            MyBubbleSort.BubbleSort(arr);
            MyQuickSort.QuickSort(arr);
        }
    }
}
