using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class Feladat2
    {
        // 2. Feladat: Készítsen egy metódust, amely paraméterként kap egy karaktertömböt, és visszaadja a karaktereket egyetlen stringként összefűzve!
        public static string Feladat02(char[] M)
        {
            string eredmeny = "";
            foreach (char c in M)
            {
                eredmeny += c;
            }
            return eredmeny;
        }
    }
}
