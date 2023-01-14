using static System.Console;
using static System.Math;

Clear();


void GetArray()
{
    int[] res = new int[8];
    int count = 0;
    while (count < res.Length)
    {
        res[count] = new Random().Next(0, 999);
        count++;
    }
    Write("[ ");
    for (int i = 0; i < res.Length; i++)
    {
        Write($"{res[i]} ");
    }
    Write(" ] ");
    WriteLine();
}

GetArray();