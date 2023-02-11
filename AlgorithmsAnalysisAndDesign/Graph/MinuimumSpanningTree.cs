using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAnalysisAndDesign.Graph
{
    public static class MinuimumSpanningTree
    {
        public static void Run()
        {
            //Vertices
            char[] labels = new char[] { '1', '2', '3', '4', '5', '6' };
            double[,] graph = new double[,]
            {
            {0,6.7,5.2,2.8,5.6,3.6 },
            {6.7,0,5.7,7.3,5.1,3.2 },
            {5.2,5.7,0,3.4,8.5,4.0 },
            {2.8,7.3,3.4,0,8,4.4 },
            {5.6,5.1,8.5,8,0,4.6 },
            {3.6,3.2,4,4.4,4.6,0 }
            };
            int verticesCount = graph.GetLength(0);
            int selectedEdgesCount = 0;

            bool[] selectedVertices = new bool[verticesCount];
            selectedVertices[0] = true;

            while (selectedEdgesCount < verticesCount - 1)
            {
                double minValue=double.MaxValue;
                int tempFrom=-1;
                int tempTo = -1;
                for (int i = 0; i < verticesCount; i++)
                {
                    if (selectedVertices[i])
                    {
                        for (int j= 0; j < verticesCount; j++)
                        {
                            bool isEdgeSuitableChoice = !selectedVertices[j] && graph[i, j] > 0 && graph[i, j] < minValue;
                            if(isEdgeSuitableChoice)
                            {
                                minValue= graph[i, j];
                                tempFrom = i;   
                                tempTo= j;
                            }
                        }
                    }
                }

                selectedVertices[tempTo] = true;
                selectedEdgesCount++;
                Console.WriteLine($"{labels[tempFrom]} => {labels[tempTo]} : {graph[tempFrom,tempTo]}"); 
            }


        }
    }
}
