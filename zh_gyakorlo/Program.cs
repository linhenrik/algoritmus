using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[] { 13, 28, 43, 37, 10, 5, 8, 99, 101, 25 };
            for (int i = 0; i < tomb.Length-1; i++)
            {
                int szamMax = i;
                for (int j = i + 1; j < tomb.Length; j++)
                {
                    if (tomb[szamMax] < tomb[j])
                    {
                        szamMax = j;
                    }
                }
                if (szamMax != i)
                {
                    int temp = tomb[i];
                    tomb[i] = tomb[szamMax];
                    tomb[szamMax] = temp;
                }
            }
            System.Console.WriteLine("Rendezett tömb:");
            foreach (int szam in tomb)
            {
                System.Console.WriteLine(szam);
            }
        }
    }
}