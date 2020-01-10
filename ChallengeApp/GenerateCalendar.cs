// ========================================================
// Generate calendar based on current month
// ========================================================
//
// Expected result
//   Januari 2020
//   S    S    R    K    J    S    M
//             1    2    3    4    5
//   6    7    8    9    10   11   12
//   13   14   15   16   17   18   19
//   20   21   22   23   24   25   26
//   27   28   29   30   31
using System;
using System.Globalization;
using System.Collections.Generic;

namespace ChallengeApp
{
    public class GenerateCalendar
    {
        public static string Calendar(string bulan)
        {
             Console.WriteLine(bulan);
             var indo = new CultureInfo("id-ID");
             DateTime waktu = DateTime.Parse("1 " + bulan,indo);
             

             var haris = new Dictionary<string,int>
             {
                {"Senin", 0},
                {"Selasa", 1},
                {"Rabu", 2},
                {"Kamis", 3},
                {"Jumat", 4},
                {"Sabtu", 5},
                {"Minggu", 6},
             };

             int mulaiHari = 0;
             int totalHari = DateTime.DaysInMonth(waktu.Year,waktu.Month);
             
             foreach(var hari in haris)
             {
                 if(waktu.ToString("dddd") == hari.Key)
                 {
                     mulaiHari = hari.Value;
                 }
             }
             
             Console.WriteLine("S    S    R    K    J    S    M");
             int batas = 0;

             for(int i = 0 ; i < 5; i++)
             {
                 for (int j=0;j < 7;j++)
                 {
                     if (batas == totalHari)
                     {
                         goto end;
                     }
                     else if ( i == 0 && j == 0)
                     {
                         j = mulaiHari;
                         Console.Write(printSpace(j));
                     }
    
                     Console.Write("{0:00}   ", batas+1);
                     batas++;
                    
                 }
                 Console.WriteLine();
             }

             end:
             return null;
        } 

        public static string printSpace(int n)
        {
            string temp ="     ";
            string ret = "";
            for(int i=0; i<n; i++)
                ret += temp;

            return ret;
        }
        
    }
}
