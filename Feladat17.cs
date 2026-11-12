using System;
using System.Collections.Generic;
using System.Text;

namespace pregtetelekCLI
{
    public static class Feladat17
    {
        //készítettem egy programot amely megadja hogy a tisza című vers első vagy második versszakában van több magánhangzó
        static string elsovsz = "Nyári napnak alkonyúlatánál Megállék a kanyargó Tiszánál Ott, hol a kis Túr siet beléje, Mint a gyermek anyja kebelére.";
        static string masodikvsz = "A folyó oly símán, oly szelíden Ballagott le parttalan medrében,Nem akarta, hogy a nap sugára Megbotoljék habjai fodrába’.";
        public static string Feladat017()
        {
            char[] maganhangzok = { 'a', 'á', 'e', 'é', 'i', 'í', 'o', 'ó', 'ö', 'ő', 'u', 'ú', 'ü', 'ű' };
            int c1 = 0;
            for (int i = 0; i < elsovsz.Length; i++)
            {
                if (maganhangzok.Contains(elsovsz[i]))
                {
                    c1++;
                }
            }
            int c2 = 0;
            for (int i = 0; i < masodikvsz.Length; i++)
            {
                if (maganhangzok.Contains(masodikvsz[i]))
                {
                    c2++;
                }
            }
            if(c1 < c2)
            {
                return "A második";
            }
            else
            {
                return "Az első";
            }
        }
    }
}
