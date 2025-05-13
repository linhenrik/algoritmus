using System;
/*Állítson elő véletlenszerűen 100 számot a 2 –500 zárt intervallumból(a 2 és az 500 is számít)  úgy, 
hogy minden  szám csak  egyszer fordulhat  elő.  Úgy kell  a feladatot megoldania, 
hogy minden szám egyenlő valószínűséggel szerepelhessen a kigenerált számok között. 
Ez után az előállított számok közül válogassa ki a prímszámokat és állítsa elő a kigenerált számok
közötti prímszámok négyzet összegét.*/
namespace feladat_4
{    class Program
    {
        static void Main(string[] args)
        {
            int[] tmb = new int[100];
            int[] primszamok = new int[tmb.Length];
            int ossz = 0;
            Random rnd = new Random();

            // 100 különböző szám kigenerálása
            int j = 0; // a tömb jelenlegi elemszáma
            while (j < 100)
            {
                int szam = rnd.Next(2, 501); 
                int k = 0;
                while (k < j && tmb[k] != szam) k++;
                if (k == j)
                {
                    tmb[j] = szam;
                    j++;
                }
            }
            Console.WriteLine("Az előállított 100 különböző szám :");
            for (int i = 0; i < 100; i++)
            {
                Console.Write(tmb[i] + " ");
            }
            // A prímszámok kiválogatása
            Console.WriteLine("\n\nA Prímszámok :"); 
            for (int i = 0; i < 100; i++)
            {
                int k = 2;
                int z = (int)Math.Sqrt(tmb[i]);
                while (k <= z && tmb[i] % k != 0)
                {
                    k++;
                }
                if (k > z)
                {
                    ossz = ossz + tmb[i] * tmb[i];    // a prímszámok négyzetösszege
                    Console.Write(tmb[i] + " ");
                }
            }
            Console.WriteLine("\nA négyzetösszeg: " + ossz);
            Console.ReadLine();
        }
    }
}

  