/* Justin Gallagher
 * C# Practice
 * 07/10/2021 */

namespace MySortingFunctions
{
    class MyInsertionSort
    {
        public static void InsertionSort(int[] arr)
        {
            int n = arr.Length - 1;
            for (int i = 1; i <= n; i++)
            {
                if (arr[i] < arr[i - 1])
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (arr[i] < arr[j])
                        {
                            int temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }
            }
        }
    }
}
