using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAnalysisAndDesign.InsertionSort
{
    public static class InsertionSortImplementattion
    {
        //Complexity O(n*n) 
        public static void InsertionSort(int[] x)
        {
            int k=0;
            int j=0;
            for (int i = 1; i < x.Length; i++)
            {
                k = x[i];
                for ( j = i-1; j >=0 ; j--)
                {
                    if (x[j] > k) x[j + 1] = x[j];
                    else break; 

                }
                x[j + 1] = k;
              
            }
            x.ToList().ForEach(i => Console.Write(i.ToString()+","));

        }
    }
}
