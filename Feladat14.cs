using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;

namespace pregtetelekCLI
{
    public static class Feladat14
    {
        static double[] valosak = { 1, 1.4, 1.5, 1.84, 3.4, 7.32, 8.32, 8.55, 9, 10.10, 11.123, 11.443 };

        public static int Feladat014(double adottSzam)
        {
            //return valosak.Where(v => v < adottSzam).Count();

            int c = 0;
            for (int i = 0; i < valosak.Length; i++)
            {
                if (valosak[i] < adottSzam)
                {
                    c++;
                }
            }
            return c;
        }
    }
}
