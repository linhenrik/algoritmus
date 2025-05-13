using System;
namespace ConsoleApp5
{
    /*  Példa az összefésülésre
     *  Két tömb, két csoport (a-8 fős,b-5 fős) pontszámait tartalmazza rendezve.
        Fésüljük össze a pontszamokat (a pontszámok 0-100 ig lehetnek) a két tömb 
        végére a 101-et mi rakjuk "kézzel" a tömbbe. Az egyenlő pontszámok esetén 
        csak az egyik kerüljön a közös tömbbe !*/
    class _28_tavol
    {
        static void Main(string[] args)
        {
            // Adatok 
            int i, j, cdb = 0;
            int[] psz_a= new int[9] { 11, 13, 19, 37, 45, 77, 86, 88, 101 }; // 101 beírtuk a tömb utolsó eleme után
            int[] psz_b= new int[6] { 1, 15, 77, 99, 100, 101 };
            int[] psz_ossz= new int[15];

            // tömbök kiíratása	
            Console.WriteLine("Az a csoport pontjai:");
            for (i = 0; i < 8; i++)
            {
                Console.Write("{0} ",psz_a[i]);
            }
            Console.WriteLine("\nA b csoport pontjai:");
            for (j = 0; j < 5; j++)
            {
                Console.Write("{0} ", psz_b[j]);
            }
            
            // összefésülés	 
            i = 0; j = 0;
            cdb = -1;
            while (i < 9 || j < 6)
            {
                if (psz_b[j] > psz_a[i]) { cdb++; psz_ossz[cdb] = psz_a[i]; i++; } // sorrend nem mindegy
                if (psz_a[i] > psz_b[j]) { cdb++; psz_ossz[cdb] = psz_b[j]; j++; }
                if (psz_a[i] == psz_b[j]) { cdb++; psz_ossz[cdb] = psz_a[i]; i++; j++; }
            }
            
            // összefésült eredmény kiíratása 
            Console.WriteLine("\nAz eredménytömb kiíratása:");
            for (j = 0; j < cdb; j++)
            {
                Console.Write("{0} ", psz_ossz[j]);
            }
         
        }
    }
}
