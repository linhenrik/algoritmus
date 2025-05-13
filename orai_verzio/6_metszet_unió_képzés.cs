using System;
namespace ConsoleApp5
{
    //Adottak az A és B tömbök, bennük 10 ill. 5 szám tárolva.Készítsük el a metszetüket és uniójukat!
    class tavol
    {
        static void Main(string[] args)
        {
            // Adatok 
            int [] A_tomb= new int[10] { 13, 28, 43, 37, 10, 5, 8, 99, 101, 2 };
            int[] B_tomb = new int[5] { 6, 43, 37, 10, 88 };
            int i, j, cdb = 0;
            int [] C_tomb=new int[15]; // metszethez is és sz unióhoz is használjuk majd

            // ömbök kiíratása	
            Console.WriteLine("Az eredeti tömbök:");
            for (i = 0; i < 10; i++)        // 10 helyett használható A_tomb.Length
            {
                Console.Write("{0} ", A_tomb[i]);
            }
            Console.WriteLine();
            for (j = 0; j < 5; j++)        // 5 helyett használható B_tomb.Length 
            {
                Console.Write("{0} ", B_tomb[j]);
            }
            // metszetképzés
            for (i = 0; i < 10; i++)
            {
                j = 0;
                while (j < 5 && A_tomb[i] != B_tomb[j])
                {
                    j++;
                }    
                if (j < 5) { C_tomb[cdb] = A_tomb[i]; cdb++; }
            }

            // metszet tömb kiíratása
            Console.WriteLine("\nA metszet tömb:");
            for (j = 0; j < cdb; j++)
            {
                Console.Write("{0} ", C_tomb[j]);
            }
            // unióképzés
            for (i = 0; i < 10; i++)
            {
                C_tomb[i] = A_tomb[i];
            }
            cdb = 10;
            for (j = 0; j < 5; j++)
            {
                i = 0;
                while (i < 10 && A_tomb[i] != B_tomb[j])
                {
                    i++;
                }   
                if (i > 9)
                { 
                    C_tomb[cdb] = B_tomb[j]; cdb++; 
                }
            }
            // unio tömb kiíratása
            Console.WriteLine("\nAz unio tömb :");
            for (j = 0; j < cdb; j++)
            {
                Console.Write("{0} ", C_tomb[j]);
            }        
        }
    }
}
