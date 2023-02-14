using AlgorithmsAnalysisAndDesign.Graph.BreadthFirstSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAnalysisAndDesign.Graph.ShortestPath
{

    public class DijkstraShortestPath
    {
        private int _lastIndex = 0;
        public Vertex[] vertices;
        public DijkstraShortestPath(char[] points)
        {
            vertices = new Vertex[points.Length];
            foreach (var point in points)
            {
                vertices[_lastIndex] = new Vertex()
                {
                    Point = point,
                };
                _lastIndex++;
            }

        }
        public void Resete()
        {
            for (int i = 0; i < this.vertices.Length; i++)
            {
                this.vertices[i].SoruceOfTotalLength = null;
                this.vertices[i].TotalLength = 0;
            }
        }

        public void AddEdges(int vertexIndex, int[] targets, double[] weights)
        {
            this.vertices[vertexIndex].VertexLinxs = new Edge[targets.Length];
            for (int i = 0; i < targets.Length; i++)
            {
                    this.vertices[vertexIndex].VertexLinxs[i] = new Edge(this.vertices[vertexIndex], this.vertices[targets[i]], weights[i]);

            }
        }
        public void RunDijkstra()
        {
            //except the start point in our case A point set weight(length) max value 
            for (int i = 1; i < this.vertices.Length; i++) 
               this.vertices[i].TotalLength = double.MaxValue;

            Vertex currentVertex;
            for (int i = 0; i < this.vertices.Length; i++)
            {
                currentVertex = this.vertices[i];
                Edge[] destenations = currentVertex.VertexLinxs;
                if (destenations is null || destenations.Length < 0) continue;
                Edge currentEdge;
                for (int j = 0; j < destenations.Length; j++)
                {
                    currentEdge = destenations[j];
                    
                    double newLength = currentVertex.TotalLength + currentEdge.Weight;
                    //To check if the collected length in greater than the weight from current vertex to the target vertex take the min weight 
                    //hint the default totalLenght is set to double.maxValue
                    if (newLength < currentEdge.Target.TotalLength)
                    { 
                        currentEdge.Target.TotalLength= newLength;
                        currentEdge.Target.SoruceOfTotalLength = currentVertex;
                    }
                }
            }
             
            Vertex targetPoint = this.vertices[vertices.Length - 1];
            string path= this.vertices[vertices.Length - 1].Point.ToString();
            while(targetPoint.SoruceOfTotalLength != null)
            {
                path= targetPoint.SoruceOfTotalLength.Point + "-" +path;
                targetPoint = targetPoint.SoruceOfTotalLength;
            }
            Console.WriteLine(path.ToString());
            Console.WriteLine(this.vertices[vertices.Length - 1].TotalLength);
        }
    }
}
