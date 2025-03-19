using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_lab1
{
    public class Problem
    {
        public int NumberOfItems { get; }
        public List<Item> Items { get; }

        public Problem(int numberOfItems, int seed) // constructor
        {
            NumberOfItems = numberOfItems;
            Items = new List<Item>();

            Random random = new Random(seed);
            for (int i = 0; i < numberOfItems; i++)
            {
                int value = random.Next(1, 11);
                int weight = random.Next(1, 11);
                Items.Add(new Item(value, weight));
            }
        }

        public Result Solve(int capacity)
        {
            var sortedItemsWithIndex = Items
                .Select((item, index) => new { Item = item, OriginalIndex = index }) // track og index after sort
                .OrderByDescending(x => x.Item.Ratio) // sort
                .ToList(); // convert to list

            List<int> selectedIndices = new List<int>(); // list of indices of selected items
            int totalValue = 0;
            int totalWeight = 0;

            foreach (var entry in sortedItemsWithIndex)
            {
                if (totalWeight + entry.Item.Weight <= capacity) // check if item will fit in backpack
                {
                    totalWeight += entry.Item.Weight;
                    totalValue += entry.Item.Value;
                    selectedIndices.Add(entry.OriginalIndex); // use og index
                }
            }

            return new Result(totalValue, totalWeight, selectedIndices); // create and return object Result
        }


        public override string ToString()
        {
            return string.Join("\n", Items);
        }
    }
}
