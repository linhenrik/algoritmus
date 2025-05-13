using System;
namespace ConsoleApp5
{
    /* Adott egy távolugró verseny döntőjének 8 végeredménye. Az eredményeket a tavol[] tömbben tároltuk.
    Adjunk választ az alábbi kérdésekre!
     1, Mennyi az ugrások átlaga?
     2, Volt-e érvénytelen ugrás?
     3, Hányan teljesítették az olimpiai szintet( > 800)?
     4, Hányan ugrottak az átlag felett?
     */ 
    class _28_tavol
    {
        static void Main(string[] args)
        {
            int[] tavol = new int[] { 650, 0, 827, 820, 799, 850, 798, 770 };
            int i, atl = 0, db1=0,db2=0;    
            //az ugarások átlaga
            for (i = 0; i <tavol.Length; i++)
            {
                atl = atl + tavol[i];  
            }
            Console.WriteLine("Az ugrások átlaga: {0}", atl / tavol.Length);
            
            // Volt-e érvénytelen ugrás ?
            i = 0;
            while (i < tavol.Length && tavol[i] != 0)
                i++;
            if (i < tavol.Length) Console.WriteLine("Volt érvénytelen eredmény.");
            else Console.WriteLine("Nem volt érvénytelen eredmény.");

            // Olimpiai szintet teljesítők, átlag felettiek száma
            for (i = 0; i < tavol.Length; i++)
            {
                if (tavol[i] > 800) db1++;                  //800 feletti ugrások száma
                if (tavol[i] > atl/tavol.Length) db2++;     //átlag feletti ugrások száma
            }
            Console.WriteLine("{0} db 800cm feletti ugrás volt.", db1);
            Console.WriteLine("{0} db átlag feletti ugrása volt.", db2);              
        }
    }
}
