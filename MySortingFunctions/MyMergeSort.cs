/* Justin Gallagher
 * C# Practice
 * 07/10/2021 */

namespace MySortingFunctions
{
    class MyMergeSort
    {
        public static void MergeSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int mid = (low + high - 1) / 2;
                MergeSort(arr, low, mid);
                MergeSort(arr, mid + 1, high);
                Merge(arr, low, mid, high);
            }
        }

        private static void Merge(int[] arr, int low, int mid, int high)
        {
            int n1 = mid - low + 1;
            int n2 = high - mid;
            
            int[] lowArr = new int[n1];
            int[] highArr = new int[n2];

            for (int i = 0; i < n1; ++i)
            {
                lowArr[i] = arr[low + i];
            }
            for (int j = 0; j < n2; ++j)
            {
                highArr[j] = arr[mid + 1 + j];
            }

            //p and q represent initial indices for lowArr and highArr, respectively.
            //r is the initial index of the merged sub-array
            int p = 0, q = 0, r = low;

            while (p < n1 && q < n2)
            {
                if (lowArr[p] <= highArr[q])
                {
                    arr[r] = lowArr[p];
                    p++;
                }
                else
                {
                    arr[r] = highArr[q];
                    q++;
                }
                r++;
            }

            while (p < n1)
            {
                arr[r] = lowArr[p];
                p++;
                r++;
            }

            while (q < n2)
            {
                arr[r] = highArr[q];
                q++;
                r++;
            }
        }
    }
}
