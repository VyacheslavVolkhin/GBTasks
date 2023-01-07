using static System.Console;
WriteLine("Enter digit");
int a = int.Parse(ReadLine()!);
int n = -a;

while (n <= a) {
    WriteLine(n);
    n++;
}