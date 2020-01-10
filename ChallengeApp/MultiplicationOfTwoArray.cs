// ========================================================
// Multiplication of two arrays
// ========================================================

// int[] firstArray = {1, 3, -5, 4};
// int[] secondArray = {1, 4, -5, -2};
//
// MultiplyArray(firstArray, secondArray)
//
// Expected result { 1, 12, 25, -8 }
using System;
using System.Collections.Generic;

namespace ChallengeApp
{
    public class MultiplicationOfTwoArray
    {   
        public static int[] Run(int[] firstArray,int[] secondArray)
        {
            int[] newArray = new int[4]; 

            for(int i=0; i <= firstArray.Length-1; i++ )
            {
                for(int j = 0 ; j <= secondArray.Length-1; j++)
                {
                    newArray[j] = firstArray[j] * secondArray[j];
                }
            }

            foreach(var x in newArray)
            {
                Console.WriteLine(x);
            }

            return newArray;

            throw new NotImplementedException();
        }
    }
}
