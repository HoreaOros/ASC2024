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
            int n;
            int baza;
            Console.WriteLine("Introduceti un numar natural");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti baza in care vreti sa convertiti numarul");
            baza = int.Parse(Console.ReadLine());
            Console.WriteLine($"n = {n}(10) = {ConvertTo(n, baza)}({baza})");
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
