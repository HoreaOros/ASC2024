using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1014_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Conversie din baza 10 in baza b (2-16)
            int n = 11259375;
            int baza = 16;
            Console.WriteLine($"n = {n}(10) = {ConvertTo(n, baza)}({baza})");


            // Conversie din baza b (2-16) in baza 10;
            string num = "   b0a1B2E3    ";
            baza = 16;

            Console.WriteLine($"n = {num.Trim()}({baza}) = {ConvertFrom(num, baza)}");

        }

        private static long ConvertFrom(string num, int baza)
        {
            long result = 0;

            num = num.Trim().ToUpper();

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] >= '0' && num[i] <= '9')
                    result = result * baza + (num[i] - '0'); 
                else
                    result = result * baza + (num[i] - 'A' + 10);
            }

            return result;
        }

        private static string ConvertTo(int n, int baza)
        {
            int cifra;
            Stack<int> stack = new Stack<int>();
            while(n > 0)
            {
                cifra = n % baza;
                n = n / baza;
                stack.Push(cifra);
            }

            StringBuilder sb = new StringBuilder();

            while(stack.Count > 0) 
            {
                cifra = stack.Pop();
                if(cifra >= 0 && cifra < 10)
                {
                    sb.Append(cifra);
                }
                else
                {
                    sb.Append((char)('A' + (cifra  - 10)));
                }
            }
            return sb.ToString();
        }
    }
}
