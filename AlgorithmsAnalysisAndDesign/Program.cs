using AlgorithmsAnalysisAndDesign.DaynamicProgramming;
using System;

namespace AlgorithmsAnalysisAndDesign
{
    public class Program
    {
     public static void Main(string[] args)
        {
			Console.WriteLine(LongestCommonSubsequence.Run());
			//LongestCommonSubsequence.Run();
			//	string mainStr = "HELLOWORLD";
			//string subStr = "OHELOD";
			//int n = mainStr.Length; 
			//int m = subStr.Length;
			//int[,] data = new int[m, n];
			//subStr = " " + subStr;
			//mainStr = " " + mainStr;
			//int k = 0;
			//	for (int i = 0; i < m; i++)
			//{
			//	for (int j = 0; j < n; j++)
			//	{
			//		if(i.Equals(0) || j.Equals(0) )
			//		      	data[i,j] = 0;
			//		else if (subStr[i].Equals(mainStr[j]))
			//			data[i,j] = k++;
			//	}
			//}
			//Console.WriteLine(data[1, 2]);
			Console.ReadKey();
        }
      
    }
}