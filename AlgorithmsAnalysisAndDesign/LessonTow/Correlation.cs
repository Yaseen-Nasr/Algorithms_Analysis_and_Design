using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAnalysisAndDesign.LessonTow
{
    public static class Correlation
    {
        public static void CalculateCorrelation()
        {
            float co = 0, suma = 0, sumb = 0, sumab = 0
                , avgx = 0, avgy = 0;
            float[] x;
            float[] y;
            Console.Write("Enter Length of the Set:");
            int n = int.Parse(Console.ReadLine());
            x = new float[n];
            y = new float[n];
            float[] ab = new float[n];

            Console.WriteLine("Enter all Numbers");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"x[{i}]=");
                x[i] = float.Parse(Console.ReadLine());
                Console.Write($"y[{i}]=");
                y[i] = float.Parse(Console.ReadLine());
                avgx += x[i];
                avgy += y[i];
            }
            avgx /= n;
            avgy /= n;
            for (int i = 0; i < n; i++)
            {

                ab[i] = (x[i] - avgx) * (y[i] - avgy);
                sumab += ab[i];
                x[i] = (float)Math.Pow(x[i] - avgx, 2);
                y[i] = (float)Math.Pow(y[i] - avgy, 2);
                suma += x[i];
                sumb += y[i];

            }
            Console.WriteLine($"{avgx}==== {avgy}");
            Console.WriteLine($"suma:{suma} -- sumb{sumb} --sumab{sumab}");
            co = (float)(sumab / Math.Sqrt(suma * sumb));
            Console.WriteLine($"Correlation is: {co}");
        }
    }
}
