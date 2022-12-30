using AlgorithmsAnalysisAndDesign.GreedyAlgorithm;
using AlgorithmsAnalysisAndDesign.HuffmanCoding;
using AlgorithmsAnalysisAndDesign.LessonTow;
using AlgorithmsAnalysisAndDesign.MegeSort;
using AlgorithmsAnalysisAndDesign.MergeSort;

namespace AlgorithmsAnalysisAndDesign
{
    public class Program
    {
     public static void Main(string[] args)
        {
            Huffman huffman = new();
            huffman.EncodingMessage("internet");
            foreach (var k in huffman.Codes.Keys)
            {
                Console.Write(k + " ");
                Console.WriteLine(huffman.Codes[k]);
            }

            Console.ReadKey();
        }
       
    }
}