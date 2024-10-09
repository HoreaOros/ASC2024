using System;


namespace _1009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            int age = 42;
            string name = "Ion";
            Console.WriteLine($"Your age is: {age}"); // string interpolation
            Console.WriteLine("Your name is {0} and your are {1} years old.", name, age); // string interpolation
            Console.WriteLine($"Your name is {name} and your are {age} years old."); // string interpolation


            Console.WriteLine("What is your age?");
            string line = Console.ReadLine();

            bool result; // valorile posibile true, false;
            result = int.TryParse(line, out age);

            if( result == true) 
                Console.WriteLine($"Your age is: {age}");
            else
                Console.WriteLine("Your input is invalid");



            int age2;
            Console.WriteLine("What is your age? (take 2)");
            line = Console.ReadLine();
            try
            {
                age2 = int.Parse(line);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(OverflowException e)
            {
                Console.WriteLine(e.Message);
            }


            sbyte b = 12; // se stocheaza pe 8 biti [-2^7, s^7  - 1]
            short s = 35; // se stocheaza pe 16 biti [-2^15, s^15  - 1]
            int x = 42; // se stocheaza pe 32 biti [-2^31, s^31  - 1]
            ulong u = 2334; // se stocheaza pe 64 biti [-2^63, s^63  - 1]

            Console.WriteLine($"sbyte [{sbyte.MinValue},{sbyte.MaxValue}]");
            Console.WriteLine($"short [{short.MinValue},{short.MaxValue}]");
            Console.WriteLine($"int [{int.MinValue},{int.MaxValue}]");
            Console.WriteLine($"long [{long.MinValue},{long.MaxValue}]");

            Console.WriteLine($"byte [{byte.MinValue},{byte.MaxValue}]");
            Console.WriteLine($"ushort [{ushort.MinValue},{ushort.MaxValue}]");
            Console.WriteLine($"uint [{uint.MinValue},{uint.MaxValue}]");
            Console.WriteLine($"ulong [{ulong.MinValue},{ulong.MaxValue}]");

            float f = 3.14f; // 32 biti
            double d = 0.001223445; // 64 biti
            Console.WriteLine($"f = {f}");
            Console.WriteLine($"d = {d}");
            Console.WriteLine($"float [{float.MinValue},{float.MaxValue}]");
            Console.WriteLine($"double [{double.MinValue},{double.MaxValue}]");

            float eps = 0.001f;
            float suma = 0.0f;
            for(int i = 0; i < 1000000; i++)
            { 
                suma = suma + eps;
                Console.Write($"{suma} ");
            }
            Console.WriteLine($"Suma = {suma}");
         }
    }
}
