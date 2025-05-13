/* Egyszerű példa feladatok az elemi progr. tételekre. Adott egy 15 elemű tömb
 mely 0 és 100 között tartalmazza 15 tanuló elért pontszámait. Alkalmazzuk 
 az elemi prog tételeket!
 1, Számítsuk ki a csoport átlag pontszámát ! 
 2, Döntsük el volt-e MAX pontszám (100 pont) !
 3, Tudjuk, hogy volt 57 pontos dogozat. Adjuk meg annak a tanulónak a sorszámát aki 57 pontot kapott!
    Ha több van elég az elsőt ! ( az első elem sorszáma 0 de a tanulók számozása 1-el kezdődik)
 4, Kérjünk be egy pontszámot és ha volt ilyen a tömbben adjuk meg a hozzá 	tartozó tanuló sorszámát!
 5, Hányan feleltek meg a vizsgán? (A pontszám > 50)
 6, Hányadik tanuló érte el a legkevesebb pontot és az mennyi volt? */

using System;
using System.Text;
namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[15] { 1, 34, 56, 4, 57, 45, 67, 6, 43, 32, 33, 99, 33, 100, 1 };
            // 1, Összegzés - számítsuk ki a csoport átlag pontszámát
            int i, sum = 0;
            for (i = 0; i < 15; i++)
            {
                sum = sum + tomb[i];
            }
            Console.WriteLine( "A csoport atlagpontszama: {0} ", (float)sum / i );

            //2, Döntsük el volt - e MAX pontszám (100 pont) !
            i = 0;
            while (i < 15 && tomb[i] != 100)
            {
                i++;

            }
            if (i < 15) Console.WriteLine("Volt 100 pontos dolgozat" );
            else Console.WriteLine("Nem volt 100 pontos dolgozat");

            // Kiválasztás - Tudjuk, hogy volt 57 pont, adjuk meg a tanuló sorszámát !
            i = 0;
            while (tomb[i] != 57)
            {
                i++;
            }
            Console.WriteLine("A(z) {0}. tanuló ért el  57 pontot ", i+1);

            // lineáris keresés - Kérjünk be egy pontszámot és ha volt ilyen a tömbben adjuk 
            //meg a hozzá 	tartozó tanuló sorszámát!
            int pont;
            Console.WriteLine("Adjon meg egy pontszámot (0-100)");
            pont=int.Parse(Console.ReadLine());
            i=0;
            while (i < 15 && tomb[i] != pont)
            {
                i++;

            }
            if (i < 15) Console.WriteLine("A(z) {0}. tanuló kapott {1} pontot", i+1,pont );
            else Console.WriteLine("Nem volt {0} pontos dolgozat",pont);

            // Megszámlálás - Hányan feleltek meg a vizsgán? (A pontszám > 50)
            int db_50pont = 0;
            for (i = 0; i < 15; i++)
            {
               if(tomb[i]>50) db_50pont++;
            }
            Console.WriteLine("{0} tanuló felelt meg a vizsgán", db_50pont);

            // Minimumkiválasztás - Hányadik tanuló érte el a legkevesebb pontot és az mennyi volt?
            int min = 0;
            for (i = 1; i < 15; i++)
            {
                if (tomb[i] < tomb[min]) min=i;
            }
            Console.WriteLine("A {0} tanuló érte el a legkevesebbet, {1} pontot", min+1,tomb[min]);
        }
    }
}
