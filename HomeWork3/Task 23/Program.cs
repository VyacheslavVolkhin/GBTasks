using static System.Console;
using static System.Math;
Clear();

WriteLine("Введите целое число: ");
if (!int.TryParse(ReadLine(), out int number)) 
{
    WriteLine("Ошибка");
}
int i = 1;

while (i <= number)
{
    WriteLine($"{i} в кубе равно {Pow(i, 3)}");
    i+=1;
}