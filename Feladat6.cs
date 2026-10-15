using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class Feladat6
    {
        public static bool Feladat06(double[] homersekletek)
        {
            // 6. Feladat: Készítsen egy metódust, amely megkapja egy hét hőmérsékleteit, majd visszaadja, hogy a hőmérséklet monoton fogyó-e!
            int index = 1;
            while (homersekletek[index] < homersekletek[index-1] || index == homersekletek.Length)
            {
                if(index == homersekletek.Length - 1)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
