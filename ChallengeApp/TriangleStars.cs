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
        public static string Stars(int jumlah)
        {
            string hasil = "";
            for(int i = 1 ; i <= jumlah; i++)
            {
                for(int j = 1 ; j <= i;j++)
                {
                   hasil += '*'; 
                }

                hasil += '\n';
            }
            return hasil;
        }
        public static int Run()
        {
            string input = Console.ReadLine();
            int jumlah = Convert.ToInt32(input);

            var hasil = Stars(jumlah);

            throw new NotImplementedException();
        }
    }
}
