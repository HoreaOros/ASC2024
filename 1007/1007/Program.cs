namespace _1007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 1007;

            convertToBase(n, 16);
        }

        private static void convertToBase(int n, int b)
        {
            int cifra;
            Stack<int> stack = new Stack<int>();
            while(n > 0)
            {
                cifra = n % b;
                stack.Push(cifra);
                n = n / b;
            }

            while(stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}