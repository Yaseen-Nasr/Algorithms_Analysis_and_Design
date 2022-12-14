using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAnalysisAndDesign.GreedyAlgorithm
{
    //Criteria , Restrictions => sorted by end time
    public static class ActivitySelectionProblem
    {
        public static List<int> SelectOptimalActivity(int[] startTime, int[] endTime)
        {
            List<int> results =new();
            int j = 0;

            //based on sorting by end time activity so the first activity added by default
            results.Add(0);
            for (int i = 1; i <= startTime.Length -1; i++)
            {
                if (startTime[i] >= endTime[j])
                {
                    results.Add(i);
                    j=i;
            
                }
            }
            return results;
        }
    }
}
