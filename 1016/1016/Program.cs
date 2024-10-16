using System;
using System.Collections.Generic;
using System.Text;

namespace _1016
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Conversie din baza 10 in baza b
            int n = 47;
            int baza = 2;
            Console.WriteLine($"n = {n}(10) -> {ConvertTo(n, baza)}({baza})");

            // Conversie din baza b in baza 10;
            string num = "CAFE";
            baza = 16;
            Console.WriteLine($"n = {num}({baza}) -> {ConvertFrom(num, baza)}(10)");
        }

        private static int ConvertFrom(string num, int baza)
        {
            int result = 0;
            num = num.ToUpper();
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] >= '0' && num[i] <= '9')
                    result = result * baza + (num[i] - '0');
                else
                    result = result * baza + (num[i] - 'A' + 10);
            }
            return result;
        }


        /// <summary>
        /// Converteste un numar din baza 10 in alta baza
        /// </summary>
        /// <param name="n">Numarul pe care il convertim</param>
        /// <param name="baza">Baza in care se face conversia</param>
        /// <returns>Numarul convertit</returns>
        private static string ConvertTo(int n, int baza)
        {
            int cifra;
            Stack<int> stack = new Stack<int>();
            while( n > 0 )
            {
                cifra = n % baza;
                n = n / baza;
                stack.Push( cifra );
            }

            StringBuilder sb = new StringBuilder();
            while( stack.Count > 0 )
            {
                cifra = stack.Pop();
                if( cifra < 10) 
                    sb.Append(cifra );
                else
                {
                    //if(cifra ==  10)
                    //    sb.Append("A");
                    //else if(cifra == 11)
                    //    sb.Append("B");
                    //else if (cifra == 12)
                    //    sb.Append("C");
                    //else if (cifra == 13)
                    //    sb.Append("D");
                    //else if (cifra == 14)
                    //    sb.Append("E");
                    //else if (cifra == 15)
                    //    sb.Append("F");
                    sb.Append((char)('A' + (cifra - 10)));
                }
            }
            return sb.ToString();
        }
    }
}
