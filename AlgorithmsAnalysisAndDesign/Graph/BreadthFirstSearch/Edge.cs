namespace AlgorithmsAnalysisAndDesign.Graph.BreadthFirstSearch
{
    public class Edge
    {
        public Vertex Source { get; }
        public Vertex Target { get; }
        public Edge(Vertex source, Vertex target)
        {
            this.Source = source;
            this.Target = target;
        }

    }
}
