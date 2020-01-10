using System;
using System.Linq;

namespace ChallengeApp
{


    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {5, 2, 5, 77, 100, 31, 3, -13, 4, 0, -19};
            int[] theFirstArray = {2, 52, 56, 12, 3};
            int[] theSecondArray = {1, 0, 65, 42};
            int[] theThirdArray = {3, 4, 6};
            int[] dups = {1, 3, 5, 1, 4, 5, 2, 4, 3, 5, 3, 1};
            int[] multiply1 = {1, 3, -5, 4};
            int[] multiply2 = {1, 4, -5, -2};

            

            // BasicStatistic.FindMax(numbers);
            // BasicStatistic.FindMin(numbers);
            // BasicStatistic.CalculateAverage(numbers);
            // BasicStatistic.CalculateTotal(numbers);

            //FlatArray.Combine(theFirstArray,theSecondArray,theThirdArray);

            //MultiplicationOfTwoArray.Run(multiply1,multiply2);
            //Separator.Run("Huda Fauzan Murtadho","*");
            //HowManyDuplicates.Run(dups);

            //TriangleOfNumbers.Run(3);
            //TriangleStars.Run(3);

            //VowelToUppercase.Run("aaaa jku suka iko enak");

            GenerateCalendar.Calendar("Januari 2019");




           // Separator.Run();
            //HowManyDuplicates.Run();
        }
    }
}
