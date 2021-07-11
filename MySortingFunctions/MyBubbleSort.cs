/* Justin Gallagher
 * C# Practice
 * 07/10/2021 */

using System;

namespace MySortingFunctions
{
    class MyBubbleSort
    {
        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length - 1;
            bool swaps = true;
            while (swaps)
            {
                int count = 0;
                for (int i = 0; i < n; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        count += 1;
                    }
                }
                if (count == 0)
                {
                    swaps = false;
                }
            }
        }
    }
}
