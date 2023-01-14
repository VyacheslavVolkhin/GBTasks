// using static System.Console;

// WriteLine("Enter digit: ");
// int a = int.Parse(ReadLine()!);

// if (a == 1) {
//     WriteLine("Monday");
// } else if (a == 2) {
//     WriteLine("Tuesday");
// } else if (a == 3) {
//     WriteLine("Wednesday");
// } else if (a == 4) {
//     WriteLine("Thursday");
// } else if (a == 5) {
//     WriteLine("Friday");
// } else if (a == 6) {
//     WriteLine("Saturday");
// } else if (a == 7) {
//     WriteLine("Sunday");
// } else {
//     WriteLine("No week day");
// }

using static System.Console;
Clear();

// // WriteLine("Enter: ");
// // int num = int.Parse(ReadLine()!);
// // int sum = GetSum(num);
// // WriteLine($"Sum number 1..A = {sum}");

// int p = GetPNumbers(int.Parse(ReadLine()!));
// WriteLine(p);




// int GetSum(int A)
// {
//     int result = 0;
//     while (A>0) {
//         result += A;
//         A--;
//     }
//     return result;
// }
// int GetSumNumbers(int B)
// {
//     int result = 0;
//     int dMain = B;
//     while(dMain > 0)
//     {
//         int digitLast = dMain%10;
//         result += digitLast;
//         dMain /= 10;
//     }
    
    
//     return result;
// }
// int GetPNumbers(int D)
// {
//     int result = 1;
//     int dMain = D;
//     while(dMain > 0)
//     {
//         int digitLast = dMain%10;
//         result *= digitLast;
//         dMain /= 10;
//     }
    
    
//     return result;
// }


// WriteLine("Input number: ");
// int[] ar = new int[8];

// for (int i = 0; i < ar.Length; i++)
// {
//     ar[i] = int.Parse(ReadLine()!);
// }

// WriteLine(ar[7]);

int[] ar = InitBinArray();
WriteLine(PrintArray(ar));
int[] InitBinArray()
{
    int[] res = new int[8];
    int i = 0;
    while (i < res.Length)
    {
        res[i] = 1;
        i++;
    }

    return res;
}
void PrintArray(int[] inArray)
{

}