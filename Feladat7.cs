using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class Feladat7
    {
        //készítettem egy metódust, ami visszaadja egy pozitív egész számokat tartalmazó tömb első 9-el osztható elemét
        public static int ElsooKilenncelOszthatoElemIndexe(int[] arr)
        {
            int i = 0;
            while (arr[i] % 9 != 0)
            {
                i++;
            }
            return i;
        }
    }
}
