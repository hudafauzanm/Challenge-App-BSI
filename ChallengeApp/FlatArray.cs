// ========================================================
// Flatting array
// ========================================================

// int[] theFirstArray = {2, 52, 56, 12, 3};
// int[] theSecondArray = {1, 0, 65, 42};
// int[] theThirdArray = {3, 4, 6};
//
// CombineArray(theFirstArray, theSecondArray, theThirdArray)
// Expected result: {0, 1, 2, 3, 3, 4, 6, 12, 42, 52, 56, 65};

using System;
using System.Linq;
using System.Collections.Generic;

namespace ChallengeApp
{
    public class FlatArray
    {
        public static int[] Combine(params int[][] arrays)
        {
            var list = new List<int>();

            foreach(var x in arrays)
            {
                list.AddRange(x);
            }

            int[] combine = list.ToArray();
            Array.Sort(combine);
            foreach(var element in combine)
            {
                Console.WriteLine(element);
            }

            return combine;

            throw new NotImplementedException();
        }
    }
}
