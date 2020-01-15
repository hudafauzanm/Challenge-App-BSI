using System;
using Xunit;
using ChallengeApp;

namespace ChallangeTest
{
    public class UnitTest1
    {
        [Fact]
        public void BasicStatistics()
        {
          int[] numbers = {5, 2, 5, 77, 100, 31, 3, -13, 4, 0, -19};

          Assert.Equal(100,BasicStatistic.FindMax(numbers));
          Assert.Equal(-19,BasicStatistic.FindMin(numbers));
          Assert.Equal(17.272727272727273,BasicStatistic.CalculateAverage(numbers));
          Assert.Equal(190,BasicStatistic.CalculateTotal(numbers));
        }

        [Fact]
        public void FlatArrays()
        {
          int[] theFirstArray = {2, 52, 56, 12, 3};
          int[] theSecondArray = {1, 0, 65, 42};
          int[] theThirdArray = {3, 4, 6};

          int[] result = {0, 1, 2, 3, 3, 4, 6, 12, 42, 52, 56, 65};

          Assert.Equal(result,FlatArray.Combine(theFirstArray,theSecondArray,theThirdArray));
        }

        [Fact]
        public void GenerateCalendar_Test()
        {
          string expected =   "S    S    R    K    J    S    M\n"
                              +"     1    2    3    4    5    6    \n"
                              +"7    8    9    10   11   12   13   \n"
                              +"14   15   16   17   18   19   20   \n"
                              +"21   22   23   24   25   26   27   \n"
                              +"28   29   30   31   ";

          Assert.Equal(expected, GenerateCalendar.Calendar("Januari 2019"));
        }

        [Fact]
        public void Duplicates()
        {
          int[] dups = {1, 3, 5, 1, 4, 5, 2, 4, 3, 5, 3, 1};

          string hasil= "1 -> 3x \n"
                      +"2 -> 1x \n"
                      +"3 -> 3x \n"
                      +"4 -> 2x \n"
                      +"5 -> 3x \n";

          Assert.Equal(hasil,HowManyDuplicates.duplicate(dups));
        }

        [Fact]
        public void Multiplication_Test()
        {
          int[] firstArray = {1, 3, -5, 4};
          int[] secondArray = {1, 4, -5, -2};

          int[] hasil = { 1, 12, 25, -8 };
          

          Assert.Equal(hasil,MultiplicationOfTwoArray.Multiplication(firstArray,secondArray));
        }

        [Fact]
        public void Separators()
        {
          Assert.Equal("m-i-n-u-m-s-u-s-u-s-a-p-i",Separator.separators("minum susu sapi"));
        }

        [Fact]
        public void Tri_Num_Test()
        {
          var expected =   "1\n"
                          +"12\n"
                          +"123\n";
                          


          Assert.Equal(expected,TriangleOfNumbers.Numbers(3));
        }


        [Fact]
        public void Tri_Stars_Test()
        {
          var expected =   "*\n"
                          +"**\n"
                          +"***\n";
                          
          Assert.Equal(expected,TriangleStars.Stars(3));
        }

        [Fact]
        public void Vowel_Test()
        {                 
          Assert.Equal("rAsAnyA OtAkkU sEmAkIn kErAm",VowelToUppercase.Run("rasanya otakku semakin keram"));
        }
    }
}
