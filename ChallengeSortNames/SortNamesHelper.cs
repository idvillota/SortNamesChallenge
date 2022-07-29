using System;
using System.Linq;

namespace ChallengeSortNames
{
	public static class SortNamesHelper
	{
        public static string[] SortNames(string[] names, int[] newOrder)
        {
            if (names == null || newOrder == null)
                throw new ArgumentException("The names and/or new order are null");

            if (names.Length != newOrder.Length)
                throw new ArgumentException("The number of names is different from the number of positions to order");

            if (newOrder.Length != newOrder.Distinct().Count())
                throw new ArgumentException("There are duplicate elements in the order array");

            var maxIndex = newOrder.Max();
            var minIndex = newOrder.Min();

            if (maxIndex > names.Length || minIndex < 1)
                throw new ArgumentException("The new indexes are out of array length");

            var orderedNames = new string[names.Length];

            for (int i = 0; i < newOrder.Length; i++)
            {
                var newIndex = newOrder[i] - 1;
                orderedNames[i] = names[newIndex];
            }

            return orderedNames;
        }
    }
}

