using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

public class Kezilabda
{
    // Adatszerkezet a játékosok adatainak tárolására
    struct Jatekos
    {
        public string Nev;
        public int Golok;
        public int Perc;
    }

    public static void Main(string[] args)
    {
        // 1. Feladat: Adatok beolvasása
        Jatekos[] jatekosok = new Jatekos[10]; // Maximum 10 játékos
        int jatekosokSzama = 0;

        // Adatok beolvasása a fájlból
        try
        {
            using (StreamReader sr = new StreamReader("kezilabda.txt"))
            {
                string sor;
                while ((sor = sr.ReadLine()) != null && jatekosokSzama < 10)
                {
                    string[] adatok = sor.Split(' ');
                    jatekosok[jatekosokSzama].Nev = adatok[0];
                    jatekosok[jatekosokSzama].Golok = int.Parse(adatok[1]);
                    jatekosok[jatekosokSzama].Perc = int.Parse(adatok[2]);
                    jatekosokSzama++;
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("A 'kezilabda.txt' fájl nem található. Kérem, adja meg az adatokat kézzel:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Játékos neve (vagy 'vege' a befejezéshez): ");
                string nev = Console.ReadLine();
                if (nev.ToLower() == "vege")
                {
                    break;
                }
                jatekosok[i].Nev = nev;

                Console.Write("Dobott gólok: ");
                jatekosok[i].Golok = int.Parse(Console.ReadLine());

                Console.Write("Játszott percek: ");
                jatekosok[i].Perc = int.Parse(Console.ReadLine());

                jatekosokSzama++;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Hiba történt a fájl beolvasása során: " + e.Message);
            return;
        }


        // 2. Feladat: Összes gól
        int osszesGol = 0;
        for (int i = 0; i < jatekosokSzama; i++)
        {
            osszesGol += jatekosok[i].Golok;
        }
        Console.WriteLine("\n2. feladat: A csapat összesen " + osszesGol + " gólt dobott.");


        // 3. Feladat: Legtöbb gólt dobó játékos
        int maxGolok = 0;
        string maxGolDobojatekos = "";
        for (int i = 0; i < jatekosokSzama; i++)
        {
            if (jatekosok[i].Golok > maxGolok)
            {
                maxGolok = jatekosok[i].Golok;
                maxGolDobojatekos = jatekosok[i].Nev;
            }
        }
        Console.WriteLine("\n3. feladat: A legtöbb gólt dobó játékos: " + maxGolDobojatekos);


        // 4. Feladat: Van-e 6 gól felett dobó játékos?
        bool van6Folott = false;
        for (int i = 0; i < jatekosokSzama; i++)
        {
            if (jatekosok[i].Golok > 6)
            {
                van6Folott = true;
                break;
            }
        }
        Console.WriteLine("\n4. feladat: Dobott-e valaki 6 gól felett? " + (van6Folott ? "igen" : "nem"));


        // 5. Feladat: Játékos keresése és játékidő
        Console.Write("\n5. feladat: Kérem, adja meg egy játékos nevét: ");
        string keresettNev = Console.ReadLine();
        bool jatszott = false;
        int jatekido = 0;
        for (int i = 0; i < jatekosokSzama; i++)
        {
            if (jatekosok[i].Nev.ToLower() == keresettNev.ToLower())
            {
                jatszott = true;
                jatekido = jatekosok[i].Perc;
                break;
            }
        }
        if (jatszott)
        {
            Console.WriteLine(keresettNev + " játszott, " + jatekido + " percet.");
        }
        else
        {
            Console.WriteLine(keresettNev + " nem játszott.");
        }


        // 6. Feladat: Átlagos játékidőnél kevesebbet játszók
        double osszesJatekido = 0;
        for (int i = 0; i < jatekosokSzama; i++)
        {
            osszesJatekido += jatekosok[i].Perc;
        }
        double atlagJatekido = osszesJatekido / jatekosokSzama;

        Console.WriteLine("\n6. feladat: Átlagos játékidőnél kevesebbet játszó játékosok:");
        for (int i = 0; i < jatekosokSzama; i++)
        {
            if (jatekosok[i].Perc < atlagJatekido)
            {
                Console.WriteLine(jatekosok[i].Nev + " " + jatekosok[i].Golok + " " + jatekosok[i].Perc);
            }
        }


        // 7. Feladat: Játékosok neveinek kiírása névsor szerint csökkenő sorrendben (Kiválasztásos rendezés)
        string[] nevek = new string[jatekosokSzama];
        for (int i = 0; i < jatekosokSzama; i++)
        {
            nevek[i] = jatekosok[i].Nev;
        }

        // Kiválasztásos rendezés (csökkenő)
        for (int i = 0; i < jatekosokSzama - 1; i++)
        {
            int maxIndex = i;
            for (int j = i + 1; j < jatekosokSzama; j++)
            {
                if (nevek[j].CompareTo(nevek[maxIndex]) > 0) // Csökkenő: >
                {
                    maxIndex = j;
                }
            }
            if (maxIndex != i)
            {
                string temp = nevek[i];
                nevek[i] = nevek[maxIndex];
                nevek[maxIndex] = temp;
            }
        }

        Console.WriteLine("\n7. feladat: Játékosok nevei csökkenő névsorrendben:");
        foreach (string nev in nevek)
        {
            Console.WriteLine(nev);
        }
        
        Console.ReadKey();
    }
}