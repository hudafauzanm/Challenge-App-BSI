// ========================================================
// Letter separators
// ========================================================

// new Separator("minum susu sapi")
// Expected output: m-i-n-u-m-s-u-s-u-s-a-p-i
//
// new Separator("minum susu sapi", '*')
// Expected output: m*i*n*u*m*s*u*s*u*s*a*p*i

using System;
using System.Text;

namespace ChallengeApp
{
    public class Separator
    {
        public static string Run(string kalimat, string sep ="-" )
        {
            string hapus = kalimat.Replace(" ",String.Empty);
            var sepr = string.Join(sep,hapus.ToCharArray());

            foreach(var x in sepr)
            {
                Console.Write(x);
            }

            return sepr;

            throw new NotImplementedException();
        }
    }
}
