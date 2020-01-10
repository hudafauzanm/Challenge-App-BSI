// ========================================================
// Generate triangle
// ========================================================
//
// TriangleStars(4);
//
// Expected result
// 1
// 12
// 123
// 1234
//
// TriangleStars(2);
//
// Expected result
// 1
// 12

using System;

namespace ChallengeApp
{
    public class TriangleOfNumbers
    {
        public static int Run(int jumlah)
        {
            for(int i = 1 ; i <= jumlah; i++)
            {
                for(int j = 1 ; j <= jumlah-1;j++)
                {
                    Console.Write("\n");
                }
                for(int k = 1; k <= i ; k++)
                {
                    Console.Write(k);
                }
            }

            return jumlah;

            throw new NotImplementedException();
        }
    }
}
