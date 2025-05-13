using System;
namespace ConsoleApplication5
{   // Az  A[] tömbben tárolunk néhány egész számot
    // Rendezzük a tömb elemeit növekvő sorrendbe az előadáson bemutatott
    //algoritmusok felhasználásával!
    class Program 
    {
        static void Main(string[] args)
        {
            int seged, ertek, i, j;
            int [ ] A= new int []  { 13, 28, 43, 37, 10, 5, 8, 99, 101, 25 };
            int db = A.Length;
            // rendezetlen tömb kiíratása	
            Console.WriteLine("A tömb elemei rendezetlenül : ");
            for ( i = 0; i < db; i++)
                Console.Write("{0}, ", A[i]);
            /**************************************************/
            //rendezés közvetlen kiválasztással    

          for( i=0;i<db-1;i++)
          {
              for( j=i+1;j<db;j++)
              {
                if(A[i]>A[j])
                {
                   seged=A[i];
                   A[i]=A[j];
                   A[j]=seged;
                }
              }
          }
            /**************************************************/
            /* rendezés minimum kiválasztással

                 for(i=0;i<db-1;i++)
                 {
                    seged=i;
                    ertek=A[i];
                    for(j=i+1;j<db;j++)
                    {
                     if(ertek>A[j])
                     {
                        ertek=A[j];
                        seged=j;
                     }
                    }
                    A[seged]=A[i];
                    A[i]=ertek;
                 }*/

            /**************************************************/
            /*buborékos rendezés

                for(i=1;i<db;i++)
                {
                  for(j=db-1;j>=i;j--) 
                  {
                   if(A[j]<A[j-1])
                     {
                     seged=A[j-1];
                     A[j-1]=A[j];
                     A[j]=seged;
                     }                 
                  }
                }*/
            /**************************************************/
                //egyszerű beillesztéses rendezés*/        
                /*for (j = 1; j < db; j++)
                {
                    i = j - 1;
                    seged = A[j];
                    while (i >= 0 && seged < A[i])
                    {
                        A[i + 1] = A[i];
                        i--;
                    }
                    A[i + 1] = seged;
                }*/
            // rendezett tömb kiíratása
            Console.WriteLine("\nA tömb elemei rendezve : ");
            for (i = 0; i < db; i++)
                Console.Write("{0}, ", A[i]);

        }
    }
}
