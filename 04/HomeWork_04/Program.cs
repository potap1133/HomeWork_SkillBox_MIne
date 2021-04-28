using System;
using System.Globalization;

namespace HomeWork_04
{
    class Program
    {
        static void Main(string[] args)
        {
            /* var k1 = 1;
             var n1 = 1;
             var n11 = 4;
             var k11 = 4;
             var f = 0;
             var f1 = 0;


             for (int i = 2; i <= n11; i++)
             {
                 n1 *= i;

             }

             for (int j = 0; j <= k11; j++)
             {
                 k1 *= j;

                 f = n11 - j;

                 f1 = 
             }



             Console.WriteLine(n1);
             Console.WriteLine(k1);
            */

            // Запрос ввлда числа.
            Console.Write($" Введите число : ");
            var n = int.Parse (Console.ReadLine());

            
            var k = n + 1;

            var num = 0;
            var gFF = 1;
            var kFF = 1;
            var nFF = 1;

            var gF = 0;
            var nF = 0;
            var kF = 0;

            int t = n;
                        
            int[,] sizeOfMasiv = new int[n, t];

            for (int i = 0; i <= n; i++)
            {
                nF = i;
                if ((nF == 0)|(nF == 1))
                {
                    nF = 1;
                }
                else if (nF <= n)
                {
                    for (int a = 2; a <= i; a++)
                    {
                        nFF *= a;
                        nF = nFF;
                    }
                }
                
                for (int j = 0; j <= i; j++)
                {
                   kF = j;

                    if ((kF == 0) | (kF == 1))
                    {
                        kF = 1;
                    }
                    else if (kF < n)
                    {
                        for (int s = 2; s <= n; s++)
                        {
                            kFF *= s;
                            kF = kFF;
                        }
                    }

                    gF = j;

                    if ((gF == 0) | (gF == 1))
                    {
                        gF = 1;
                    }
                    else if (gF <= n)
                    {
                        for (int x = 2; x <= n; x++)
                        {
                            gFF *= x;
                            gF = gFF;
                        }
                    }

                    num = nF / (kF * gF);
                    sizeOfMasiv[i, j] = num;
                    Console.Write($" {sizeOfMasiv[i , j]} ");
                    
                }
                Console.WriteLine();
                continue;
            }

            Console.ReadKey();
        }
    }
}
