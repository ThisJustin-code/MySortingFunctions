/* Justin Gallagher
 * C# Practice
 * 07/12/2021 */

namespace MySortingFunctions
{
    class MyRadixSort
    {
        public static void RadixSort(int[] arr)
        {
            int n = arr.Length;
            int max = arr[0];
            for (int i = 0; i < n; i++)
                if (arr[i] > max)
                    max = arr[i];

            for (int exp = 1; max / exp > 0; exp *= 10)
            {
                int[] output = new int[n];
                int[] count = new int[10];
                int i;

                for (i = 0; i < 10; i++)
                    count[i] = 0;

                for (i = 0; i < n; i++)
                    count[(arr[i] / exp) % 10]++;

                for (i = 1; i < 10; i++)
                    count[i] += count[i - 1];

                for (i = n - 1; i >= 0; i--)
                {
                    output[count[(arr[i] / exp) % 10] - 1] = arr[i];
                    count[(arr[i] / exp) % 10]--;
                }

                for (i = 0; i < n; i++)
                    arr[i] = output[i];
            }
        }
    }
}
