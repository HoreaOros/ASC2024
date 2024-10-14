using System.Text;

int n = 47;
int b = 2;
Console.WriteLine($"n = {n}(10) = {ConvertFromBase10(n, b)}({b})");



///<summary>
///Convertește numărul n din baza 10 in baza b
///</summary>
string ConvertFromBase10(int n, int b)
{
    if(b < 2 || b > 16)
    {
        throw new ArgumentException("Baza trebuie sa fie intre 2 si 16");
    }

    Stack<int> stack = new Stack<int>();
    int rest;
    while(n > 0)
    {
        rest = n % b;
        stack.Push(rest);
        n = n / b;
    }

    StringBuilder sb = new StringBuilder();
    

    while(stack.Count > 0)
    {
        sb.Append(stack.Pop());
    }
    return sb.ToString();
}