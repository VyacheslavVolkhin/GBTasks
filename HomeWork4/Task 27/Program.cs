using static System.Console;
using static System.Math;

Clear();



WriteLine("Enter A:");
int A = int.Parse(ReadLine()!);

WriteLine(GetSumm(A));

int GetSumm(int a)
{
    int res = 0;
    int lastDigit = 0;
    while (a > 0)
    {
        lastDigit = a%10;
        res +=lastDigit;
        a /=10;
    }
    return res;
}