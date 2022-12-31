using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAnalysisAndDesign.FractionalKnapsackProblem
{
    public class Knapsack
    {
        public int MaxCapacity { get;private set; }
        public int CurrentCapacity { get;private set; }
        public double TotalValue{ get;private set; }
        public List<Item> items { get; private set; }

        public Knapsack(int maxCapacity)
        {
            this.MaxCapacity = maxCapacity;
            items=new List<Item>(); 
        }
        public void AddItem(Item newItem)
        {
            int remainingCapacity = MaxCapacity - CurrentCapacity;
            if (newItem.Weight > remainingCapacity)
            {
                newItem.Weight= remainingCapacity;
                newItem.Value = remainingCapacity * newItem.Ratio;
            }
            items.Add(newItem);
            CurrentCapacity += newItem.Weight;
            TotalValue += newItem.Value;
                   
        }

    }
}
