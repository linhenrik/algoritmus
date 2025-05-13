using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Egy utazó ügynök az alábbi városokban járt januárban:
Kecskemet, Szeged, Pecs, Baja, Gyor, Miskolc, Vac, Cegled, Sopron, Eger
Februárban az alábbi városokat látogatta meg:
Budapest, Kecskemet, Szeged,Pecs,Baja, Esztergom, Salgotarjan
Azt tudjuk, hogy egyik hónapban sem dolgozott 10 napnál többször.
Készítsünk programot mely kimutatja:
1 - Hány városban járt januárban ill. februárban?
2 - Mely városokban járt mindkét hónapban ?
3 - Mely városokban volt legalább egyszer a két hónap alatt? */
     
namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, jdb, fdb, cdb = 0;
            string [] A =new string[] { "Kecskemet", "Szeged", "Pecs", "Baja","Gyor", "Miskolc", "Vac", "Cegled", "Sopron", "Eger"};
            string [] B = new string[] { "Budapest", "Kecskemet", "Szeged", "Pecs", "Baja", "Esztergom", "Salgotarjan" };      
            // 1.
            jdb = A.Length;
            fdb = B.Length;
            string [] C = new string[jdb+fdb];
            Console.WriteLine("{0} városban járt januárban.\n {1} városban járt februárban.", jdb, fdb);
            // Mindkét hónapban látogatta ( metszet)
            for (i = 0; i < jdb; i++)
            {
                j = 0;
                while (j < fdb && A[i] != B[j])
                    j++;
                if (j < fdb) { C[cdb] = A[i]; cdb++; }
            }
           Console.WriteLine("Az alábbi városokban járt mindkét hónapban :");
            for (i = 0; i < cdb; i++)
                Console.Write("{0}, ",C[i]);

            // Legalább az egyik hónapban látogatta ( unió)
            for (i = 0; i < jdb; i++)
            {
                C[i] = A[i];
            }
            cdb = jdb;
            for (j = 0; j < fdb; j++)
            {
                i = 0;
                while (i < jdb && A[i] != B[j])
                    i++;
                if (i > jdb - 1) { C[cdb] = B[j]; cdb++; }
            }
            Console.WriteLine("\nAz alábbi városokban járt legalább az egyik hónapban :");
            for (i = 0; i < cdb; i++)
                Console.Write("{0}, ", C[i]);
            }
    }
}
