

using AlgorithmsAnalysisAndDesign.Graph.ShortestPath;

namespace AlgorithmsAnalysisAndDesign
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DijkstraShortestPath dijkstraShortestPath = new(new char[] { 'A', 'b', 'C', 'D', 'E', 'F', 'G', 'H', 'I','J' });
           dijkstraShortestPath.AddEdges(0, new int[] { 1, 2 ,3},new double[] {2,4,3});

           dijkstraShortestPath.AddEdges(1, new int[] { 4,5,6 }, new double[] { 7,4,6 });
           dijkstraShortestPath.AddEdges(2, new int[] { 4, 5, 6 }, new double[] { 3, 2, 4 });
           dijkstraShortestPath.AddEdges(3, new int[] { 4, 5, 6 }, new double[] { 4, 1, 5 });

           dijkstraShortestPath.AddEdges(4, new int[] { 7,8 }, new double[] { 1,4 });
           dijkstraShortestPath.AddEdges(5, new int[] { 7,8 },new double[] { 6, 3 });
           dijkstraShortestPath.AddEdges(6, new int[] { 7,8 },new double[] { 3, 3 }); 

           dijkstraShortestPath.AddEdges(7, new int[] { 9 },new double[] { 3 });
            dijkstraShortestPath.AddEdges(8, new int[] { 9 }, new double[] { 4 });
            dijkstraShortestPath.RunDijkstra();

            Console.ReadKey();
        }
      
    }
}