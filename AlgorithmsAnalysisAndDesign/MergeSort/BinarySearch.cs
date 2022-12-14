using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAnalysisAndDesign.MergeSort
{
    internal class BinarySearch
    {
        //1,2,3,4,5,6,7,8
        public static int Search(int[] x, int target)
        {
            int left=0;
            int right=x.Length-1;
            int mid=(left+right)/2;
            while(left<=right)
            {
                if (x[mid] == target)
                {
                    return mid + 1;
                }
                else if (x[mid] > target)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                    mid = (left + right) / 2;
                }    
            }
            return -1;
        }
    }
}
