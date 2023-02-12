using AlgorithmsAnalysisAndDesign.Graph.BreadthFirstSearch;

namespace AlgorithmsAnalysisAndDesign.Graph.FirstSearch
{
    public class Graph
    {
        #region Example
        //Graph.BreadthFirstSearch.Graph g = new Graph.BreadthFirstSearch.Graph(new char[] { 'A', 'b', 'C', 'D', 'E', 'F', 'G', 'H', 'I' });
        //g.AddEdges(0, new int[] { 1, 2 });
        //g.AddEdges(1, new int[] { 0, 3,4 });
        //g.AddEdges(2, new int[] { 0, 3, 5 });
        //g.AddEdges(3, new int[] { 1, 2,4 });
        //g.AddEdges(4, new int[] { 1, 5 });
        //g.AddEdges(5, new int[] { 2, 3,4,7 });
        //g.AddEdges(6, new int[] { 7, 8 });
        //g.AddEdges(7, new int[] { 5,6, 8 });
        //g.AddEdges(8, new int[] { 6 , 7 });

        //g.BFS();

        #endregion
        private int _lastIndex = 0;
        public Vertex[] vertices;

        public Graph(char[] points)
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
        //to add edges to specific vertex
        public void AddEdges(int vertexIndex, int[] targets)
        {
            this.vertices[vertexIndex].VertexLinxs = new Edge[targets.Length];
            for (int i = 0; i < targets.Length; i++)
            {
                this.vertices[vertexIndex].VertexLinxs[i] = new Edge(this.vertices[vertexIndex], this.vertices[targets[i]]);

            }
        }
      
        public void BFS()
        {
            Console.WriteLine("Breadth First Search");
            if (vertices is null)
                return;
            Queue<Vertex> queue = new Queue<Vertex>();
            queue.Enqueue(this.vertices[0]);
            this.vertices[0].IsVisited = true;
            Vertex currentVertex;
            Edge[] destinations;
            while (queue.Count > 0)
            {
                currentVertex = queue.Dequeue();
                destinations = currentVertex.VertexLinxs;
                for (int i = 0; i < destinations.Length; i++)
                {
                    bool isTargetVertexIsNotVisited = !destinations[i].Target.IsVisited;
                    if (isTargetVertexIsNotVisited)
                    {
                        queue.Enqueue(destinations[i].Target);
                        destinations[i].Target.IsVisited = true;
                        Console.WriteLine($"{currentVertex.Point} - {destinations[i].Target.Point}");
                    }
                }
            }
            ResetVertices();
        }

        public void DFS()
        {
            Console.WriteLine("Depth First Search");

            DFSRecursion(this.vertices[0]);
            ResetVertices();
        }
        private void DFSRecursion(Vertex currentVertex)
        {
            currentVertex.IsVisited = true;
            Edge[] destinations = currentVertex.VertexLinxs;
            for (int i = 0; i < destinations.Length; i++)
            {
                bool isTargetVertexIsNotVisited = !destinations[i].Target.IsVisited;
                if (isTargetVertexIsNotVisited)
                {
                    Console.WriteLine($"{currentVertex.Point} - {destinations[i].Target.Point}");
                    DFSRecursion(destinations[i].Target);

                }
            }
        }
        private void ResetVertices() 
        {
            foreach (var vertex in this.vertices)
            {
                vertex.IsVisited = false;
            }
        }
    }
}
