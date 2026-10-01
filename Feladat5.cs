using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class Feladat5
    {
    
        public static bool Feladat05(string nap)
        {
            // 5. Feladat: Készítsen egy metódust, amely kap egy stringet, és megnézi hogy a string egy hét napja-e, majd visszaadja az eredményt!
            string[] napok = { "hétfő", "kedd", "szerda", "csütörtök", "péntek", "szombat", "vasárnap" };
            if (napok.Contains(nap.ToLower()))
            {
                return true;
            }
            else { return false; }
        }

    }
}
