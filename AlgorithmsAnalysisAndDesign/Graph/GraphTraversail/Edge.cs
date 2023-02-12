namespace AlgorithmsAnalysisAndDesign.Graph.BreadthFirstSearch
{
    public class Edge
    {
        public Vertex Source { get; }
        public Vertex Target { get; }
        public Edge(Vertex source, Vertex target)
        {
            Source = source;
            Target = target;
        }

    }
}
