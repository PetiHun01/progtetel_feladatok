using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class Feladat1
    {
        // 1. Feladat: Készítsen egy metódust, amely létrehoz egy 30 elemű listát, amelynek elemei véletlenszerűen generált számok 1 és 5 között, majd számolja ki az osztályátlagot!
        public static void Feladat01()
        {
            List<int> atlagok = [];
            Random rnd = new Random();
            for (int i = 0; i < 30; i++)
            {
                int szam = rnd.Next(1, 5);
                atlagok.Add(szam);
            }
            double osztalyatlag = atlagok.Average();
            Console.WriteLine("1. Feladat: Az osztályátlag: {0}", osztalyatlag);
        }
        
    }
}