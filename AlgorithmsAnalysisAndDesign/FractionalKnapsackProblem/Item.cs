using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAnalysisAndDesign.FractionalKnapsackProblem
{
    public class Item
    {
        public string Name { get; set; }
        public double Value { get; set; }
        public int Weight{ get; set; }
        public double Ratio{ get; set; }
        public Item(string name, double value, int weight)
        {
            Name = name;
            Value = value;
            Weight = weight;
            Ratio = value/weight;
        }
        public override string ToString()
        {
            return $"name {Name} value {Value} weight {Weight} ratio {Ratio}"; 
        }
    }
}
