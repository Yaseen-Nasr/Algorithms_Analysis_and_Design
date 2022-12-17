using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAnalysisAndDesign.MegeSort
{
    public static class MergeSortImpl
    {
        public static void SortArray (int[] array, int start, int end)
        {
            if (end <= start) return;

            int middlePoint = (end + start) / 2;

            SortArray(array, start, middlePoint);
            SortArray(array, middlePoint + 1, end);
            Merge(array, start, middlePoint, end);
        }
        public static void Merge(int[] array, int start, int middlePoint, int end)
        {
            int i, j, k;
            int left_Length = middlePoint - start + 1;
            int right_Length = end - middlePoint;
            int[] leftArray = new int[left_Length];
            int[] rightArray = new int[right_Length];


            for (i = 0; i < left_Length; i++)
            {
                leftArray[i] = array[start + i];

            }
            for (j = 0; j < right_Length; j++)
            {
                rightArray[j] = array[middlePoint + 1 + j];

            }
            i = 0;
            j = 0;
            k = start;
            while (i < left_Length && j < right_Length)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    array[k] = leftArray[i];
                    i++;

                }
                else
                {
                    array[k] = rightArray[j];
                    j++;
                }
                k++;
            }
            while (i < left_Length)
            {
                array[k] = leftArray[i];
                i++;
                k++;

            }
            while (j < right_Length)
            {
                array[k] = rightArray[j];
                j++;
                k++;
            }
        }
    }
}
