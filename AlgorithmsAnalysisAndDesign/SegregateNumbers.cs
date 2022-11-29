using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAnalysisAndDesign
{
    public static class SegregateNumbers
    {
        public static void Segregate(int[] arr, int start, int end)
        {
            if (end <= start) return;

            int mid = (start + end) / 2;
            Segregate(arr, start, mid);
            Segregate(arr, mid + 1, end);
            Merg(arr, start, mid, end);
        }
        public static void Merg(int[] arr, int start, int mid, int end)
        {
            int i, j, k;
            int leftLength = mid - start + 1;
            int rightLength = end - mid;
            int[] leftArr = new int[leftLength];
            int[] rightArr = new int[rightLength];
            for (i = 0; i < leftLength; i++)
            {
                leftArr[i] = arr[start + i];
            }
            for (j = 0; j < rightLength; j++)
            {
                rightArr[j] = arr[mid + 1 + j];
            }
            i = 0;
            j = 0;
            k = start;
            while (i < leftLength && leftArr[i] <= 0)
            {
                arr[k] = leftArr[i];
                i++;
                k++;
            }
            while (j < rightLength && rightArr[j] <= 0)
            {
                arr[k] = rightArr[j];
                j++;
                k++;
            }
            while (i < leftLength)
            {
                arr[k] = leftArr[i];
                i++;
                k++;
            }
            while (j < rightLength)
            {
                arr[k] = rightArr[j];
                j++;
                k++;
            }

        }
    }
}
