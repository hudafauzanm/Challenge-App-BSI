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
        public static string Numbers(int jumlah)
        {
            string hasil = "";
            for(int i = 1 ; i <= jumlah; i++)
            {
                for(int j = 1 ; j <= i;j++)
                {
                   hasil += Convert.ToString(j); 
                }

                hasil += '\n';
            }
            return hasil;
        }
        public static int Run()
        {
            string input = Console.ReadLine();
            int jumlah = Convert.ToInt32(input);

            var hasil = Numbers(jumlah);

            throw new NotImplementedException();
        }
    }
}
