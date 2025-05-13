using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* A városok tömbben néhány város nevét tároljuk. Rendezzük névsor szerint növekvő sorrendbe, 
majd írjuk ki a képernyőre*/
namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] varosok = new string[] { "Cegled", "Pecs", "Vac", "Miskolc", "Ada", "Kaposvár" };
            // rendezés előtt
            Console.WriteLine("Rendezés előtt :");
            for (int i = 0; i < varosok.Length; i++)
            {
                Console.Write("{0} ", varosok[i]);
            }

            // rendezés közvetlen kiválasztással
            for (int i = 0; i < varosok.Length-1; i++)
            {
                for (int j = i + 1; j < varosok.Length; j++)
                {
                    if (varosok[i].CompareTo(varosok[j]) == 1) // 1 ha j van előbb -1 ha i 0 ha egyformák 
                    {
                        string seged = varosok[i];
                        varosok[i] = varosok[j];
                        varosok[j] = seged;
                    }
                }
            }
            // rendezés után
            Console.WriteLine("\nRendezés után :");
            for (int i = 0; i < varosok.Length; i++)
            {
                Console.Write("{0} ", varosok[i]);
            }
            Console.WriteLine();
        }
    }
}
