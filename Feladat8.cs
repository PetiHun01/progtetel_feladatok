using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class Feladat8
    {
        public static int HonapSzamaNevAlapjan(string honap)
        {
            //készítettem egy programot, mely megadja egy hónap neve alapján annak a hónapnak a sorszámát, hibás bemenet esetén pedig -1et ad vissaz
            string[] honapok = ["január", "február", "március", "április", "május", "június", "július", "augusztus", "szeptember", "október", "november", "december"];
            if (honapok.Contains(honap.ToLower()))
            {
                return Array.FindIndex(honapok, s => s.StartsWith(honap)) + 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
