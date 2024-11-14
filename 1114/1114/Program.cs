// ~ complement
// << deplasare pe biti la stanga
// >> deplasare pe biti la dreapta
// & - SI
// | - SAU
// ^ - XOR
//3322 2222 2222 1111 1111 1100 0000 0000
//1098 7654 3210 9876 5432 1098 7654 3210
//---------------------------------------
//0000 0000 0001 0011 0011 0100 0000 0001
//0000 0000 0001 0011 0011 0100 0000 0001
uint n = 1258497;

DisplayBitPattern(n, 32);

SetBit(ref n, 11);
DisplayBitPattern(n, 32);

ResetBit(ref n, 11);
DisplayBitPattern(n, 32);


uint m = 1584795;
uint k = 1259946;
uint c = m ^ k;
Console.WriteLine($"{m} XOR {k} = {c}");

uint d = c ^ k;
Console.WriteLine($"{c} XOR {k} = {d}");


//0000 0000 0001 0011 0011 1100 0000 0001
//1111 1111 1111 1111 1111 0111 1111 1111
void ResetBit(ref uint n, int pos)
{
    uint mask = 0;
    mask = ~(1u << pos);
    n = n & mask;
}



void SetBit(ref uint n, int pos)
{
    n = n | (1u << pos);
}

void DisplayBitPattern(uint n, int size)
{
    for(int i = size - 1; i >= 0; i--)
    {
        Console.Write(n >> i & 1u);
    }
    Console.WriteLine();
}

//n = 0000 0000 0001 0011 0011 0100 0000 0001
//1 = 0000 0000 0000 0000 0000 0000 0000 0001
