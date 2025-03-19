using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_lab1
{
    public class Item
    {
        public int Value { get; }
        public int Weight { get; }
        public double Ratio => (double)Value / Weight;

        public Item(int value, int weight) // constructor
        {
            Value = value;
            Weight = weight;
        }

        public override string ToString()
        {
            return $"value: {Value}, weight: {Weight}, ratio: {Ratio:F2}";
        }
    }
}
