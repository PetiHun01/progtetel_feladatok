using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class Feladat10
    {
        //Készítettem egy programot, amely egy fontos magyar történelmi évszámokat tartalmazó tömbből megkeresi az aranybulla indexét
        public static int AranybullaIndex(int[] evszamok)
        {
            return Array.FindIndex(evszamok, s => s == 1222);
        }
    }
}
