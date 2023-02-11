using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAnalysisAndDesign.Graph.BreadthFirstSearch
{
    public class Vertex
    {
        public char Point { get; set; }
        public Edge[] VertexLinxs { get; set; } = null!;
        public bool IsVisited { get; set; }

    }
}
