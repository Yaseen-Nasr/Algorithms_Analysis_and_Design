namespace AlgorithmsAnalysisAndDesign.Graph.BreadthFirstSearch
{
    public class Edge
    {
        public Vertex Source { get; }
        public Vertex Target { get; }
        public double Weight { get; }
        public Edge(Vertex source, Vertex target, double weight=0)
        {
            Source = source;
            Target = target;
            Weight = weight;
        }

    }
}
