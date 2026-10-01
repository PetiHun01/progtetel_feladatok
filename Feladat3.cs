using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class Feladat3
    {
        public static int Feladat03(int N)
        {
            // 3. Feladat: Készítsen egy metódust, amely N számu számig összeadja az összes természetes számot, majd visszaadja az eredményt!
            int ossz = 0;
            for (int i = 0; i <= N; i++)
            {
                ossz+= i;
            }
            return ossz;
        }
    }
}
