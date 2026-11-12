
using System;
using System.Collections.Generic;
using System.Text;

namespace pregtetelekCLI
{
    static public class Feladat16
    {
        //készítettem egy programot amely megadja hogy a tisza című vers első versszakában hány mgánhangzó van
        static string elsovsz = "Nyári napnak alkonyúlatánál Megállék a kanyargó Tiszánál Ott, hol a kis Túr siet beléje, Mint a gyermek anyja kebelére.";
        public static int Feladat016()
        {
            char[] maganhangzok = { 'a', 'á', 'e', 'é', 'i', 'í', 'o', 'ó', 'ö', 'ő', 'u', 'ú', 'ü', 'ű' };
            int c = 0;
            for (int i = 0; i < elsovsz.Length; i++)
            {
                if (maganhangzok.Contains(elsovsz[i]))
                {
                    c++;
                }
            }
            return c;
        }
    }
}
