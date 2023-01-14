using static System.Console;
using static System.Math;

Clear();



WriteLine("Enter A:");
int A = int.Parse(ReadLine()!);

WriteLine("Enter B:");
int B = int.Parse(ReadLine()!);

WriteLine(PowNumbers(A, B));

int PowNumbers(int a, int b)
{
    int res = A;
    int i = 1;
    while (i < b)
    {
        res = res*A;
        i++;
    }
    return res;
}