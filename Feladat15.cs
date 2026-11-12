using System;
using System.Collections.Generic;
using System.Text;

namespace pregtetelekCLI
{
    public static class Feladat15
    {
        //készytettem egy programot, mely megadja hogy egy adott mennyiségű jegynek hány %-a ötös
        
        public static double Feladat015()
        {
            List<int> jegyek = [];
            Random r = new Random();
            double c = 0;
            for(int i = 0; i < 20 ; i++)
            {
                jegyek.Add(r.Next(1, 6));
            }
            for(int i = 0;i < jegyek.Count ; i++)
            {
                if(jegyek[i] == 5)
                {
                    c++;
                }
            }
            if(c != 0)
            {
                return (c / (double)jegyek.Count) * 100;
            }
            else { return 0; }
        }
    }
}
