using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAnalysisAndDesign.FractionalKnapsackProblem
{
    public  class Example
    {
        public void Run()
        {
            int[] Values = { 4, 9, 12, 11, 6, 5 };
            int[] Weights = { 1, 2, 10, 4, 3, 5 };
            Item[] items = new Item[Values.Length];
            int j = 0;
            for (int i = 0; i < Values.Length; i++)
            {
                Item item = new($"#{i}", Values[i], Weights[i]);
                items[i]= item;

            }
            //useing merg sort 
            SortByRatioDescending.SortArray(items,0,items.Length -1);
           // print items after sort
            foreach (var item in items)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("------------------------------------");

            Knapsack knapsack = new Knapsack(12);
            while(knapsack.CurrentCapacity < knapsack.MaxCapacity)
            {
                knapsack.AddItem(items[j]);
                j++;
            }
            Console.WriteLine($"Total Value : {knapsack.TotalValue}  Current Capacity: {knapsack.CurrentCapacity}");
            Console.WriteLine("Items: ");
           
            foreach (var item in knapsack.items)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
