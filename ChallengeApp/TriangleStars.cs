// ========================================================
// Generate triangle
// ========================================================
//
// TriangleStars(5);
//
// Expected result
// *
// **
// ***
// ****
// *****
//
// TriangleStars(2);
//
// Expected result
// *
// **

using System;

namespace ChallengeApp
{
    public class TriangleStars
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
                    Console.Write("*");
                }
            }

            return jumlah;
            throw new NotImplementedException();
        }
    }
}
