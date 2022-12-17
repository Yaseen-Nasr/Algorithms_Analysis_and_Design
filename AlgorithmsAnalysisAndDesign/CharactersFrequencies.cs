using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAnalysisAndDesign
{
    public static class CharactersFrequencies
    {
        public static void ASCIIFrequency(string str)
        {
            int[] freq = new int[127];
            for (int i = 0; i < str.Length; i++)
            {
                int currentCode =(int) str[i];
                freq[currentCode]++;
            }
            for (int i = 0; i < freq.Length; i++)
            {
                if (freq[i] > 0 ) 
                    Console.WriteLine($"{(char)i} => {freq[i]}");
            }
        }

        public static void AnyFrequencyCharCode(string str)
        {
           Hashtable freq = new();
            for (int i = 0; i < str.Length; i++)
            {
                //first time initial value 1
                if (freq[str[i]] is null)
                {
                    freq[str[i]] = 1;
                }
                else
                {
                    freq[str[i]] = (int)freq[str[i]]! +1;
                }

            }
            //foreach (var c in freq.Keys)
            //{
            //    Console.WriteLine($"{c} => {freq[c]}");
            //}


            SortHasch(freq);
        }
        public static void SortHasch(Hashtable freq)
        {
            int[,] arr = new int[freq.Count, 2];
            int k = 0;
            foreach (char c in freq.Keys)
            {
                arr[k, 0] = (int)c;
                arr[k, 1] = (int)freq[c]!;
                k++;
            }
            SortArray(arr, 0,freq.Count-1);
            for (int i = 0; i < freq.Count; i++)
            {
                Console.WriteLine($"{(char)arr[i,0]} => {arr[i, 1]}");
            }
        }
        private static void SortArray(int[,] array, int start, int end)
        {
            if (end <= start) return;

            int middlePoint = (end + start) / 2;

            SortArray(array, start, middlePoint);
            SortArray(array, middlePoint + 1, end);
            Merge(array, start, middlePoint, end);
        }
        private static void Merge(int[,] array, int start, int middlePoint, int end)
        {
            int i, j, k;
            int left_Length = middlePoint - start + 1;
            int right_Length = end - middlePoint;
            int[,] leftArray = new int[left_Length,2];
            int[,] rightArray = new int[right_Length,2];


            for (i = 0; i < left_Length; i++)
            {
                leftArray[i,0] = array[start + i,0];
                leftArray[i,1] = array[start + i,1];

            }
            for (j = 0; j < right_Length; j++)
            {
                rightArray[j,0] = array[middlePoint + 1 + j, 0];
                rightArray[j,1] = array[middlePoint + 1 + j, 1];

            }
            i = 0;
            j = 0;
            k = start;
            while (i < left_Length && j < right_Length)
            {
                if (leftArray[i,1] <= rightArray[j, 1])
                {
                    array[k, 0] = leftArray[i, 0];
                    array[k, 1] = leftArray[i, 1];
                    i++;

                }
                else
                {
                    array[k, 0] = rightArray[j, 0];
                    array[k, 1] = rightArray[j, 1];
                    j++;
                }
                k++;
            }
            while (i < left_Length)
            {
                array[k, 0] = leftArray[i, 0];
                array[k, 1] = leftArray[i, 1];
                i++;
                k++;

            }
            while (j < right_Length)
            {
                array[k, 0] = rightArray[j, 0];
                array[k, 1] = rightArray[j, 1];
                j++;
                k++;
            }
        }
    }
}
