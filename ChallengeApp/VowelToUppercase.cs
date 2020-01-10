// ========================================================
// Covert all vowel letters into uppercase
// ========================================================
// Input: rasanya otakku semakin keram
// Expected result
// rAsAnyA OtAkkU sEmAkIn kErAm
using System;
using System.Text;

namespace ChallengeApp
{
    public class VowelToUppercase
    {
        public static string Run(string kalimat)
        {
            StringBuilder sb = new StringBuilder (kalimat);
            sb.Replace("a","A");
            sb.Replace("i","I");
            sb.Replace("o","O");
            sb.Replace("u","U");
            sb.Replace("e","E");
            
            Console.WriteLine(sb);

            return sb.ToString();
        }
    }
}
