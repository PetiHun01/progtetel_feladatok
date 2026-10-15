using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class Feladat9
    {
        public static int lukacsNevnapja()
        {
            //Az október havi névnapok sorozata alapján megadjuk , hogy Lukácsnak
            //hányadikán van a névnapja!
            Dictionary<int, string> oktoberiNevnapok = [];
            oktoberiNevnapok.Add(1, "Malvin");
            oktoberiNevnapok.Add(2, "Petra");
            oktoberiNevnapok.Add(3, "Helga");
            oktoberiNevnapok.Add(4, "Ferenc");
            oktoberiNevnapok.Add(5, "Aurél");
            oktoberiNevnapok.Add(6, "Brúnó;Renáta");
            oktoberiNevnapok.Add(7, "Amália");
            oktoberiNevnapok.Add(8, "Koppány");
            oktoberiNevnapok.Add(9, "Dénes");
            oktoberiNevnapok.Add(10, "Gedeon");
            oktoberiNevnapok.Add(11, "Brigitta");
            oktoberiNevnapok.Add(12, "Miksa");
            oktoberiNevnapok.Add(13, "Ede;Kálmán");
            oktoberiNevnapok.Add(14, "Helén");
            oktoberiNevnapok.Add(15, "Teréz;Terézia");
            oktoberiNevnapok.Add(16, "Gál");
            oktoberiNevnapok.Add(17, "Hedvig");
            oktoberiNevnapok.Add(18, "Lukács");
            oktoberiNevnapok.Add(19, "Nándor");
            oktoberiNevnapok.Add(20, "Vendel");
            oktoberiNevnapok.Add(21, "Orsolya");
            oktoberiNevnapok.Add(22, "Előd");
            oktoberiNevnapok.Add(23, "Gyöngyi");
            oktoberiNevnapok.Add(24, "Salamon");
            oktoberiNevnapok.Add(25, "Bianka;Blanka");
            oktoberiNevnapok.Add(26, "Dömötör");
            oktoberiNevnapok.Add(27, "Szabina");
            oktoberiNevnapok.Add(28, "Simon;Szimonetta");
            oktoberiNevnapok.Add(29, "Nárcisz;Teofil");
            oktoberiNevnapok.Add(30, "Alfonz;Kolos;Fanni");
            oktoberiNevnapok.Add(31, "Farkas");

            return oktoberiNevnapok.FirstOrDefault(x => x.Value == "Lukács").Key;

            //Október 1. - Malvin
            //Október 2. - Petra
            //Október 3. - Helga
            //Október 4. - Ferenc
            //Október 5. - Aurél
            //Október 6. - Brúnó, Renáta
            //Október 7. - Amália
            //Október 8. - Koppány
            //Október 9. - Dénes
            //Október 10. - Gedeon
            //Október 11. - Brigitta
            //Október 12. - Miksa
            //Október 13. - Ede, Kálmán
            //Október 14. - Helén
            //Október 15. - Teréz, Terézia
            //Október 16. - Gál
            //Október 17. - Hedvig
            //Október 18. - Lukács
            //Október 19. - Nándor
            //Október 20. - Vendel
            //Október 21. - Orsolya
            //Október 22. - Előd
            //Október 23. - Gyöngyi
            //Október 24. - Salamon
            //Október 25. - Bianka, Blanka
            //Október 26. - Dömötör
            //Október 27. - Szabina
            //Október 28. - Simon, Szimonetta
            //Október 29. - Nárcisz, Teofil
            //Október 30. - Alfonz, Kolos, Fanni
            //Október 31. - Farkas
        }
    }
}
