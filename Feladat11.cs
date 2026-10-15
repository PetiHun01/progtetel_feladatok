using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class Feladat11
    {
        //készítettem egy programot, mely megnézi hogy egy számsor taraémaz-e -5nél kisebb elemet, amennyiben igen, visszaadja az indexét.
        public static int MinuszOtnelKisebbElemIndexe(double[] szamok)
        {
            if (szamok.Any(s => s < -5))
            {
                return Array.FindIndex(szamok, x => x < -5);
            }
            else
            {
                return -1;
            }
        }
    }
}
