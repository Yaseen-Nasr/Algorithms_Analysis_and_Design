namespace AlgorithmsAnalysisAndDesign.Graph.BreadthFirstSearch
{
    public class Graph
    {
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
            this.vertices[vertexIndex].VertexLinxs=new Edge[targets.Length];
            for (int i = 0; i < targets.Length; i++)
            {
                this.vertices[vertexIndex].VertexLinxs[i] = new Edge(this.vertices[vertexIndex], this.vertices[targets[i]]);

            }
        }
        public void BFS()
        {
            if (vertices is null)
                return;
            Queue<Vertex> queue = new Queue<Vertex>();
            queue.Enqueue(this.vertices[0]);
            this.vertices[0].IsVisited= true;
            Vertex currentVertex;
            Edge[] destinations;
            while(queue.Count > 0)
            {
                currentVertex = queue.Dequeue();
                destinations = currentVertex.VertexLinxs;
                for (int i = 0; i < destinations.Length; i++)
                {
                    bool isTargetVertexIsNotVisited = !destinations[i].Target.IsVisited;
                    if(isTargetVertexIsNotVisited)
                    {
                        queue.Enqueue(destinations[i].Target);
                        destinations[i].Target.IsVisited = true;
                        Console.WriteLine($"{currentVertex.Point} - {destinations[i].Target.Point}");
                    }
                }
            }
        }
    }
}
