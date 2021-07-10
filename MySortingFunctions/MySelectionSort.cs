/* Justin Gallagher
 * C# Practice
 * 07/10/2021 */

using System;

namespace MySortingFunctions
{
    class MySelectionSort
    {
        public static void SelectionSort(int[] arr)
        {
            int n = arr.Length - 1;
            for (int i = 1; i < n; i++)
            {
                int min = i;
                for (int j = i + 1; j <= n; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    int temp = arr[min];
                    arr[min] = arr[i];
                    arr[i] = temp;
                }
            }
            Console.WriteLine("Selection Sort: ");
            Console.WriteLine("[{0}]", string.Join(", ", arr));
        }
    }
}
