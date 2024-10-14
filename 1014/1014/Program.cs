using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Conversie din  baza 10 in baza b (2-16)
            int n;
            int baza;
            Console.WriteLine("Introduceti un numar natural");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti baza in care vreti sa convertiti numarul");
            baza = int.Parse(Console.ReadLine());
            Console.WriteLine($"n = {n}(10) = {ConvertTo(n, baza)}({baza})");


            // Conversie din baza b(2-16) in baza 10
            Console.WriteLine("Introduceti un numar natural");
            string numar = Console.ReadLine();
            Console.WriteLine("Introduceti baza in care este numarul");
            baza = int.Parse(Console.ReadLine());
            Console.WriteLine($"Valoare lui {numar} in baza {baza} este {ConvertFrom(numar, baza)}");
        }
        /// <summary>
        /// Converteste un numar din baza <paramref name="baza"/> in baza 10 
        /// </summary>
        /// <param name="numar">Numarul care se converteste</param>
        /// <param name="baza">Baza din care se face conversia</param>
        /// <returns>Numarul in baza 10</returns>
        /// <example>DA34F = ??</example>
        private static int ConvertFrom(string numar, int baza)
        {
            int numarCifre = numar.Length;
            int valoare = 0;
            int cifra = 0;
            numar = numar.ToUpper();
            for(int i = 0; i < numarCifre; i++)
            {
                if (numar[i] >= '0' && numar[i] <= '9')
                    cifra = numar[i] - '0';
                else
                {
                    switch(numar[i])
                    {
                        case 'A':
                            cifra = 10;
                            break;
                        case 'B':
                            cifra = 11;
                            break;
                        case 'C':
                            cifra = 12;
                            break;
                        case 'D':
                            cifra = 13;
                            break;
                        case 'E':
                            cifra = 14;
                            break;
                        case 'F':
                            cifra = 15;
                            break;
                    }
                }

                valoare = valoare * baza + cifra;
            }
            return valoare;
        }

        private static string ConvertTo(int n, int baza)
        {
            int cifra;
            Stack<int> stack = new Stack<int>();
            while( n > 0 )
            {
                cifra = n % baza;
                stack.Push( cifra );
                n = n / baza;
       
            }

            StringBuilder sb = new StringBuilder();
            
            while(stack.Count > 0)
            {
                cifra = stack.Pop();
                if(cifra < 10)
                    sb.Append( cifra );
                else
                {
                    sb.Append( (char)('A' + (cifra-10)) );
                }
            }
            return sb.ToString();
        }
    }
}
