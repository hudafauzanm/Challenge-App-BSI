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

            
            //====================BASIC STATISTIC======================================//
            BasicStatistic.FindMax(numbers);
            BasicStatistic.FindMin(numbers);
            BasicStatistic.CalculateAverage(numbers);
            BasicStatistic.CalculateTotal(numbers);
            //=====================FLAT ARRAY==========================================//
            FlatArray.Combine(theFirstArray,theSecondArray,theThirdArray);
            //=====================MULTIPICATION=======================================//
            MultiplicationOfTwoArray.Run(multiply1,multiply2);
            //=====================SEPARATOR===========================================//
            Separator.Run("Huda Fauzan Murtadho","*");
            //=====================DUPLICATE===========================================//
            HowManyDuplicates.Run(dups);
            //=====================TRIANGELNUMBER======================================//
            TriangleOfNumbers.Run(3);
            //=====================TRIANGELSTARTS======================================//
            TriangleStars.Run(3);
            //=============================VOWEL=======================================//
            VowelToUppercase.Run("aaaa jku suka iko enak");
            //====================================CALENDAR=============================//
            GenerateCalendar.Calendar("Januari 2019");




           // Separator.Run();
            //HowManyDuplicates.Run();
        }
    }
}
