using System;
/*A Pontszam 8 elemű tömbben egy csoport zh eredményeinek pontszámait helyeztük el(0-100)
növekvő sorrendben. Határozzuk meg, hogy egy billentyűzetről bekért pontszám
eleme -e a tömbnek és ha igen hányadik? - LOGARITMIKUS KERESÉS*/
namespace ConsoleApplication4
{    class Program
    {
        static void Main(string[] args)
        {
            int[] Pontszam = new int[8] { 2,67,78,89,90,92,95,100,};
            int pont, k, A = 0, F = 7;
            Console.WriteLine("Adja meg a keresett pontot!");
            pont=int.Parse(Console.ReadLine());
            do
            {
                k = (A + F) / 2;
                if (Pontszam[k] < pont) { A = k + 1; }
                if (Pontszam[k] > pont) { F = k - 1; }
            }
            while (A <= F && Pontszam[k] != pont);
            if (A <= F) Console.WriteLine("A keresett pont a Pontszam tömb {0} indexu eleme", k );  //0 az első elem
            else Console.WriteLine("A keresett pont nincs a Pontszam tömbben");
        }
    }
}