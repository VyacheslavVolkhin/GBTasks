using static System.Console;
Clear();

// int number = new Random().Next(100, 1000);
// int a1 = number/100;
// int a2 = number%10;
// WriteLine(number);
// WriteLine($"{a1},{a2}");

// WriteLine("Enter num1: ");
// int a1 = int.Parse(ReadLine()!);
// int a2 = 7;
// int a3 = 23;

// WriteLine(a1%a2==0 && a1%a3==0?"Yes":$"No");

WriteLine("Enter num1: ");
int a1 = int.Parse(ReadLine()!);
WriteLine("Enter num2: ");
int a2 = int.Parse(ReadLine()!);

WriteLine(a1*a1==a2?"a1^a1=a2":a2*a2==a1?"a2^a2=a1":"No");