/* Justin Gallagher
 * C# Practice
 * 07/10/2021 */

namespace MySortingFunctions
{
    class MyQuickSort
    {
        public static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int mid = Partition(arr, low, high);

                QuickSort(arr, low, mid - 1);
                QuickSort(arr, mid + 1, high);
            }
        }

        private static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;

            for (int j = low; j <= high - 1; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    int t2 = arr[i];
                    arr[i] = arr[j];
                    arr[j] = t2;
                }
            }
            int t1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = t1;

            return i + 1;
        }
    }
}
