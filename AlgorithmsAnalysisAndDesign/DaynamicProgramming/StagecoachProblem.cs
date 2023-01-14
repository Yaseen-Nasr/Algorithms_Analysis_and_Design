using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAnalysisAndDesign.DaynamicProgramming
{
    public class StagecoachProblem
    {
        // here the problem link https://www.ii.uib.no/saga/SC96EPR/stagecoach.html
        //This problem to find optimal route with mini Cost So This example Represent Specific case so 
        //Labels Are the points that Represent The route from (A to J) across all other points
        //Data represent the Route value from point to another ordaring by position
        public static void Run()
        {
            char[] labels = new[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };
            int[,] data = new[,] {
                { 0,2,4,3,0,0,0,0,0,0},
                { 0,0,0,0,7,4,6,0,0,0},
                { 0,0,0,0,3,2,4,0,0,0},
                { 0,0,0,0,4,1,5,0,0,0},
                { 0,0,0,0,0,0,0,1,4,0},
                { 0,0,0,0,0,0,0,6,3,0},
                { 0,0,0,0,0,0,0,3,3,0},
                { 0,0,0,0,0,0,0,0,0,3},
                { 0,0,0,0,0,0,0,0,0,4},
                { 0,0,0,0,0,0,0,0,0,0},
            };

            int n = data.GetLength(1);
            Point[] states = new Point[n];
            states[n - 1] = new Point();


            int newCost = 0;
            //i = n-2 mean that we start backWord and Ignorw "J"
            for (int i = n - 2; i >= 0; i--)
            {
                int j = i + 1;
                states[i] = new Point { From = labels[i], To = labels[j], Cost = int.MaxValue };

                for (; j < n; j++)
                {
                    if (data[i, j] == 0)
                        continue;
                    newCost = data[i, j] + states[j].Cost;
                    if (newCost < states[i].Cost)
                    {
                        states[i].To = labels[j];
                        states[i].Cost = newCost;
                    }
                }

            }

            // To see all routes to choseen points 
            //foreach (var state in states)
            //{
            //    Console.WriteLine(state.ToString());
            //}

            StringBuilder path = new();
            // entery point 
            path.Append('A');
            int m = 0;
            int k = 0;
            while (m < states.Length)
            {
                if (states[m].From == path[k])
                {
                    path.Append(states[m].To);
                    k++;
                }
                m++;
            }
            Console.WriteLine($"minimum cost : {states[0].Cost}");
            Console.WriteLine($"minimum path: {path.AppendFormat(",")}");

        }
    }
     
    internal class Point
    {
        public char From { get; set; } 
        public char To { get; set; } 
        public int Cost { get; set; }
        public override string ToString()
        {
            return $"From:{From} , To:{To}, Cost:{Cost}"; 
        }
    }
}
