using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class Feladat12
    {

        public static int VesztesegesNap(Dictionary<int, int> nap)
        {
            int index = 0;

            foreach (var (bevetel, kiadas) in nap)
            {
                if (bevetel - kiadas < 0)
                    return index;

                index++;
            }

            return -1; 
        }

    }
}
