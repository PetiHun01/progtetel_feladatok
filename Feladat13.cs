using System;
using System.Collections.Generic;
using System.Text;

namespace pregtetelekCLI
{
    public static class Feladat13
    {
        static string[] Erkezesek = { "00:52", "04:57", "05:17", "05:37", "05:57", "06:17", "06:37", "06:57", "07:17", "07:37", "07:57"};

        public static List<string> Feladat013()
        {
            List<string> megfelelok = [];
            foreach(var e in Erkezesek)
            {
                var oraperc = e.Split(':');
                var ora = int.Parse(oraperc[0]);
                var perc = int.Parse(oraperc[1]);

                if (ora == 7 && perc >= 30 && perc <= 45)
                {
                    megfelelok.Add($"{ora}:{perc}");
                }
            }
            if (megfelelok.Any())
            {
                return megfelelok;
            }
            else
            {
                return null;
            }
        }
    }
}
