using AlgorithmsAnalysisAndDesign.Graph.BreadthFirstSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAnalysisAndDesign.Graph.ShortestPath
{
    #region Example
    //    DijkstraShortestPath dijkstraShortestPath = new(new char[] { 'A', 'b', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' });
    //    dijkstraShortestPath.AddEdges(0, new int[] { 1, 2 ,3},new double[] { 2, 4, 3 });

    //dijkstraShortestPath.AddEdges(1, new int[] { 4, 5, 6 }, new double[] { 7, 4, 6 });
    //dijkstraShortestPath.AddEdges(2, new int[] { 4, 5, 6 }, new double[] { 3, 2, 4 });
    //dijkstraShortestPath.AddEdges(3, new int[] { 4, 5, 6 }, new double[] { 4, 1, 5 });

    //dijkstraShortestPath.AddEdges(4, new int[] { 7, 8 }, new double[] { 1, 4 });
    //dijkstraShortestPath.AddEdges(5, new int[] { 7, 8 }, new double[] { 6, 3 });
    //dijkstraShortestPath.AddEdges(6, new int[] { 7, 8 }, new double[] { 3, 3 });

    //dijkstraShortestPath.AddEdges(7, new int[] { 9 }, new double[] { 3 });
    //dijkstraShortestPath.AddEdges(8, new int[] { 9 }, new double[] { 4 });
    //dijkstraShortestPath.RunDijkstra();

    #endregion
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
                        currentEdge.Target.TotalLength = newLength;
                        currentEdge.Target.SoruceOfTotalLength = currentVertex;
                    }
                }
            }

            Vertex targetPoint = this.vertices[vertices.Length - 1];
            string path = this.vertices[vertices.Length - 1].Point.ToString();
            while (targetPoint.SoruceOfTotalLength != null)
            {
                path = targetPoint.SoruceOfTotalLength.Point + "-" + path;
                targetPoint = targetPoint.SoruceOfTotalLength;
            }
            Console.WriteLine(path.ToString());
            Console.WriteLine(this.vertices[vertices.Length - 1].TotalLength);
        }
    }
}
