﻿using AlgorithmsAnalysisAndDesign.LessonTow;
using AlgorithmsAnalysisAndDesign.MegeSort;

namespace AlgorithmsAnalysisAndDesign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(LessoneOne.ParallelogramArea(3,4));
            //Console.WriteLine(LessoneOne.trapezoidArea(6,12,4));
            // StandardDivision.CalcStandardDivision();
            //Correlation.CalculateCorrelation();
            //int[] x = { 9, 5, 1, 4, 3,8,10 };
            //InsertionSort.InsertionSortImplementattion.InsertionSort(x);
            int[] x = { 9, 5, 1, 4, 3, 8, 10 };
            Console.WriteLine(String.Join(", ", x));
            MergeSortImpl.SortArray(x, 0, x.Length - 1);
            Console.WriteLine(String.Join(", ", x));


        }
       
    }
}