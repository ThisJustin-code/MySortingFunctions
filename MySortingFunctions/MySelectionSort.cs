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
            for (int i = 0; i < n; i++)
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
        }
    }
}
