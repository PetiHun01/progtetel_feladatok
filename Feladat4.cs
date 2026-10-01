using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class Feladat4
    {
        private static bool Feladat04(double[] jegyek)
        {
            // 4. Feladat: Készítettem egy metódust, amely megkapja egy tanuló év végi jegyeit, majd visszaadja, hogy a tanuló kitűnő-e vagy sem!
            double avg = jegyek.Average();
            if (avg == 5.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
