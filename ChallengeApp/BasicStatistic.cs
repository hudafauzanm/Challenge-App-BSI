// ========================================================
// Basic statistics - WITHOUT LINQ
// ========================================================

// int[] numbers = {5, 2, 5, 77, 100, 31, 3, -13, 4, 0, -19};
//
// FindMax(numbers);
//
// FindMin(numbers);
//
// CalculateAverage(numbers);
//
// CalculateTotal(numbers);

using System;

namespace ChallengeApp
{
    public class BasicStatistic
    {
        public static int FindMax(int[] numbers)
        {
            // Find maximum value "without" using LINQ
            //int[] numbers = {5, 2, 5, 77, 100, 31, 3, -13, 4, 0, -19};

            int mx = numbers[0];
            //int i;
            for(int i = 1 ; i < numbers.Length; i++)
            {
                if ( numbers[i] > mx)
                {
                    mx = numbers[i];
                }
            }

            Console.WriteLine(mx);
            return mx;
            //Console.WriteLine(mx);
            throw new NotImplementedException();
        }

        public static int FindMin(int[] numbers)
        {
            // Find minimum value "without" using LINQ
            int mn = numbers[0];
            //int i;
            for(int i = 1 ; i < numbers.Length; i++)
            {
                if ( numbers[i] < mn)
                {
                    mn = numbers[i];
                }
            }
            Console.WriteLine(mn);
            return mn;

            throw new NotImplementedException();
        }

        public static double CalculateAverage(int[] numbers)
        {
            // Calculate average value "without" using LINQ
            double result = 0;
             for( int i = 1 ; i < numbers.Length;i++)
             {
                 result += numbers[i];
             }
            double results = (double)result / numbers.Length;

            Console.WriteLine(results);

            return results;
             
            throw new NotImplementedException();
        }

        public static int CalculateTotal(int[] numbers)
        {
            // Calculate total value "without" using LINQ
            int hasil = 0;

            for ( int i = 1 ; i < numbers.Length; i ++)
            {
                hasil += numbers[i];
            }
            Console.WriteLine(hasil);
            return hasil;
            throw new NotImplementedException();
        }
    }
}
