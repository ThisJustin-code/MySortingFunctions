/* Justin Gallagher
 * C# Practice
 * 07/10/2021 */

using System;
using System.Diagnostics;
using System.Linq;

namespace MySortingFunctions
{
    class MySortingTests
    {
        static void Main(string[] args)
        {
            // create simple unsorted array

            int size = 100000;

            Console.WriteLine("Creating unsorted array of " + size + " intgers...");

            int[] tempArr = new int[size];

            for (int i = 0; i < tempArr.Length; i++)
                tempArr[i] = i + 1;

            Random r = new Random();
            int[] bigArr = tempArr.OrderBy(x => r.Next()).ToArray();

            // create test arrays
            int[] selectionTestArray = new int[bigArr.Length];
            int[] insertionTestArray = new int[bigArr.Length];
            int[] bubbleTestArray = new int[bigArr.Length];
            int[] mergeTestArray = new int[bigArr.Length];
            int[] quickTestArray = new int[bigArr.Length];
            int[] heapTestArray = new int[bigArr.Length];
            int[] radixTestArray = new int[bigArr.Length];

            // copy original array into test arrays
            bigArr.CopyTo(selectionTestArray, 0);
            bigArr.CopyTo(insertionTestArray, 0);
            bigArr.CopyTo(bubbleTestArray, 0);
            bigArr.CopyTo(mergeTestArray, 0);
            bigArr.CopyTo(quickTestArray, 0);
            bigArr.CopyTo(heapTestArray, 0);
            bigArr.CopyTo(radixTestArray, 0);

            Console.WriteLine("Array created.");

            Stopwatch timer = new Stopwatch();

            // run sorting algorithms on the array and print test results

            Console.WriteLine("\nBegin Selection Sort...");
            timer.Start();
            MySelectionSort.SelectionSort(selectionTestArray);
            timer.Stop();
            Console.WriteLine("Selection Sort Complete");
            ElapsedTimeString(timer.Elapsed);
            timer.Reset();
            //Console.WriteLine("[{0}]", string.Join(", ", selectionTestArray));

            Console.WriteLine("\nBegin Insertion Sort...");
            timer.Start();
            MyInsertionSort.InsertionSort(insertionTestArray);
            timer.Stop();
            Console.WriteLine("Insertion Sort Complete");
            ElapsedTimeString(timer.Elapsed);
            timer.Reset();
            //Console.WriteLine("[{0}]", string.Join(", ", insertionTestArray));

            Console.WriteLine("\nBegin Bubble Sort...");
            timer.Start();
            MyBubbleSort.BubbleSort(bubbleTestArray);
            timer.Stop();
            Console.WriteLine("Bubble Sort Complete");
            ElapsedTimeString(timer.Elapsed);
            timer.Reset();
            //Console.WriteLine("[{0}]", string.Join(", ", bubbleTestArray));

            Console.WriteLine("\nBegin Merge Sort...");
            timer.Start();
            MyMergeSort.MergeSort(mergeTestArray, 0, mergeTestArray.Length - 1);
            timer.Stop();
            Console.WriteLine("Merge Sort Complete");
            ElapsedTimeString(timer.Elapsed);
            timer.Reset();
            //Console.WriteLine("[{0}]", string.Join(", ", mergeTestArray));

            Console.WriteLine("\nBegin Quick Sort...");
            timer.Start();
            MyQuickSort.QuickSort(quickTestArray, 0, quickTestArray.Length - 1);
            timer.Stop();
            Console.WriteLine("Quick Sort Complete");
            ElapsedTimeString(timer.Elapsed);
            timer.Reset();
            //Console.WriteLine("[{0}]", string.Join(", ", quickTestArray));

            Console.WriteLine("\nBegin Heap Sort...");
            timer.Start();
            MyHeapSort.HeapSort(heapTestArray);
            timer.Stop();
            Console.WriteLine("Heap Sort Complete");
            ElapsedTimeString(timer.Elapsed);
            timer.Reset();
            //Console.WriteLine("[{0}]", string.Join(", ", heapTestArray));

            Console.WriteLine("\nBegin Radix Sort...");
            timer.Start();
            MyRadixSort.RadixSort(radixTestArray);
            timer.Stop();
            Console.WriteLine("Radix Sort Complete");
            ElapsedTimeString(timer.Elapsed);
            timer.Reset();
            //Console.WriteLine("[{0}]", string.Join(", ", radixTestArray));
        }
        static void ElapsedTimeString(TimeSpan elapsed)
        {
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            elapsed.Hours, elapsed.Minutes, elapsed.Seconds,
            elapsed.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }
    }
}

/*
PREVIOUS RUNS:

Creating unsorted array of 100000 intgers...
Array created.

Begin Selection Sort...
Selection Sort Complete
RunTime 00:00:12.83

Begin Insertion Sort...
Insertion Sort Complete
RunTime 00:00:18.87

Begin Bubble Sort...
Bubble Sort Complete
RunTime 00:00:50.51

Begin Merge Sort...
Merge Sort Complete
RunTime 00:00:00.02

Begin Quick Sort...
Quick Sort Complete
RunTime 00:00:00.01

Begin Heap Sort...
Heap Sort Complete
RunTime 00:00:00.04

Begin Radix Sort...
Radix Sort Complete
RunTime 00:00:00.01

Creating unsorted array of 100000000 intgers...
Array created.

Begin Merge Sort...
Merge Sort Complete
RunTime 00:00:38.70

Begin Quick Sort...
Quick Sort Complete
RunTime 00:00:26.76

Begin Heap Sort...
Heap Sort Complete
RunTime 00:01:41.20

Begin Radix Sort...
Radix Sort Complete
RunTime 00:00:24.27
*/
