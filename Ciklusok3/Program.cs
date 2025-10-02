using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Random rnd = new Random();
        List<int> szamok = new List<int>();

        // 50 véletlen szám generálása 1 és 100 között
        for (int i = 0; i < 50; i++)
        {
            szamok.Add(rnd.Next(1, 101));
        }

        // Változók az eredményekhez
        int osszeg = 0;
        int min = 101; 
        int max = 0;   
        bool vanKisebb5 = false;
        List<int> nagy90 = new List<int>();

        
        for (int i = 0; i < szamok.Count; i++)
        {
            int szam = szamok[i];

            // Összeg
            osszeg += szam;

            // Minimum 
            if (szam < min)
                min = szam;

            // Maximum 
            if (szam > max)
                max = szam;

            // Van-e 5-nél kisebb?
            if (szam < 5)
                vanKisebb5 = true;

            // 90 feletti számok
            if (szam > 90)
                nagy90.Add(szam);
        }

        // Átlag számítása
        double atlag = (double)osszeg / szamok.Count;

        // Kiírás
        Console.WriteLine("Generált számok: " + string.Join(", ", szamok));
        Console.WriteLine("Összeg: " + osszeg);
        Console.WriteLine("Átlag: " + atlag);
        Console.WriteLine("Legnagyobb elem: " + max);
        Console.WriteLine("Legkisebb elem: " + min);
        Console.WriteLine("Van-e 5-nél kisebb szám? " + (vanKisebb5 ? "Igen" : "Nem"));
        Console.WriteLine("90-nél nagyobb számok darabszáma: " + nagy90.Count);

        if (nagy90.Count > 0)
        {
            Console.WriteLine("90-nél nagyobb számok: " + string.Join(", ", nagy90));
        }
    }
}
