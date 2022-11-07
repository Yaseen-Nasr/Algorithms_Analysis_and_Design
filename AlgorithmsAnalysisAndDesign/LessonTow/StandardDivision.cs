using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAnalysisAndDesign.LessonTow
{
    public static class StandardDivision
    {
        public static void CalcStandardDivision()
        {

            double avg = 0, a = 0, b = 0, sb = 0;
            double[] x;
            Console.Write("Enter Length of the Set:");
            int n = int.Parse(Console.ReadLine());
            x = new double[n];

            Console.WriteLine("Enter all Numbers");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"x[{i}]=");
                x[i] = int.Parse(Console.ReadLine());
                avg += x[i];
            }
            avg /= n;
            for (int i = 0; i < n; i++)
            {
                a += Math.Pow(x[i] - avg, 2);
            }
            b = a / n;
            sb = Math.Sqrt(b);
            Console.WriteLine($"Standard Deviation is :  {sb}");
        }
    }
}
