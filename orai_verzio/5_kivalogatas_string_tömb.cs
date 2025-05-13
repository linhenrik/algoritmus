using System;
namespace ConsoleApplication4
{    class Program
    {
        static void Main(string[] args)
        {
        // Egy utazó ügynök az alábbi 10 városban járt januárban : Vac, Pecs,Szeged, Tata, Vac, Gyor, Pecs, Tata, Vac, Eger
        // Válogassuk ki a varosokat egy új tömbbe úgy hogy mindegyik csak egyszer szerepeljen benne
        string[] varosok = new string [] { "Vac", "Pecs", "Szeged", "Tata", "Vac", "Gyor", "Pecs", "Tata", "Vac", "Eger" };
        string []uj= new string[varosok.Length];
        int ujdb = 0;       //az uj tömbben lévő elemek darabszáma -  jelenleg 0, üres a tömb
        for (int i = 0; i < 10; i++)   // vegyük egyenként a városokat
        {
            int j = 0;
            while (j < ujdb && varosok[i] != uj[j]) // döntsük el, hogy az adott város benne van-e már az új tömbben
                j++;
            if (j == ujdb)      //ha úgy szálltunk ki a ciklusból, hogy nem volt az adott város az uj tömbben
            {
                uj[ujdb] = varosok[i];
                ujdb++;                 // növeljük az uj tömbben lévő városok számát
            }
        }
        for (int i = 0; i < ujdb; i++)
        {
           Console.WriteLine( uj[i]);
        }
           }
    }
}