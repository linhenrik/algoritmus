using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/* Egy max 12 fős kosárlabda csapat adatait tároljuk egy struktúra tömbben.
 * Tároljuk a játékosok nevét, magasságaát, és dobott pontjait. 
 * 1, Kérjük be ellenőrzötten a csapat létszámát (5-12)
 * 2, Töltsük fel a struktúratömböt adatokkal úgy, hogy a nevet billentyűzetről kérjük be, 
 * a magasságot és pontokat véletlengenerátorral állítsuk elő. 
 * A magasság 170- 220 cm, a dobott pontok 0-100 között lehetnek. 
 * 3,Írassuk ki az adatokat táblázatosan!
 * 4, Számítsuk ki a csapat pont átlagát!
 * 5, Ki a legmagasabb (adjuk meg a nevét)
 * 6, Az ötven pont felett dobók száma
 * 7, Írja ki a képernyőre a játékosok nevét és dobott pontjait a pontok 
 * szerint növekvő sorrendben!
 */
namespace ConsoleApplication13
{
    class Program
    {
        struct kosar
        {
            public string nev;
            public int magassag;
            public int pont;
        }
        static void Main(string[] args)
        {
            int letszam;
            //1, Létszám ellenőrzött bekérése
            do
            {
                Console.WriteLine("Adja meg a létszámot 5-12 között!");
                letszam = int.Parse(Console.ReadLine());
            }
            while (letszam > 12 || letszam < 5);
            //2,  Csapat adatainak bekérése
            kosar[] csapat = new kosar[letszam];
            Random rnd = new Random();
            for (int i = 0; i < letszam; i++)
            {
                Console.WriteLine("adja meg az {0}. játékos nevét :", i + 1);
                csapat[i].nev = Console.ReadLine();
                csapat[i].magassag = rnd.Next(170, 221);
                csapat[i].pont = rnd.Next(0, 101); 
            }
            //3, Osztály adatainak táblázatos kiíratása
            Console.Clear();
            for (int i = 0; i < letszam; i++)
            {
                Console.WriteLine("{0}. {1,-20} {2, -5}{3,5}", i + 1, csapat[i].nev, csapat[i].magassag, csapat[i].pont);
            }

            //4, Számítsuk ki a csapat pont átlagát!
            float átl = 0;
            for (int i = 0; i < letszam; i++)
            {
                átl = átl + csapat[i].pont;
            }
            Console.WriteLine("A csapat pontátlaga: {0}", átl/letszam);

            //5, Legmagasabb játekos neve

            int max = 0;
            for (int i = 1; i < letszam; i++)
            {
                if (csapat[i].magassag > csapat[max].magassag) { max = i; }
            }
            Console.WriteLine("A legmagasabb jatekos neve: {0}", csapat[max].nev);

            //6, Az ötven pont felett dobók száma
            int db50 = 0;
            for (int i = 0; i < letszam; i++)
            {
                if (csapat[i].pont > 50)
                {
                    db50++;
                }
            }
            Console.WriteLine("Az ötven pont felett dobók száma: {0}", db50);

            //7, Rendezés
            int j;
            for (int i = 0; i < letszam - 1; i++)
            {
                for (j = i + 1; j < letszam; j++)
                {
                    if (csapat[i].pont > csapat[j].pont)
                    {
                        kosar seged = csapat[i];
                        csapat[i] = csapat[j];
                        csapat[j] = seged;
                    }
                }
            }
            for (int i = 0; i < letszam; i++)
            {
                Console.WriteLine("{0}. {1,-20} {2,5} ", i + 1,csapat[i].nev,csapat[i].pont);
            }
        }

    }
}

