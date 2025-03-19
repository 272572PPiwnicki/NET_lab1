using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_lab1
{
    public class Result
    {
        public int TotalValue { get; }
        public int TotalWeight { get; }
        public List<int> SelectedItems { get; }

        public Result(int totalValue, int totalWeight, List<int> selectedItems) // constructor
        {
            TotalValue = totalValue;
            TotalWeight = totalWeight;
            SelectedItems = selectedItems;
        }

        public override string ToString()
        {
            return $"total value: {TotalValue}, total weight: {TotalWeight}, selected items: [{string.Join(", ", SelectedItems)}]";
        }
    }
}
