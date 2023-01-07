using static System.Console;
Clear();
WriteLine("Введите любое число: ");
int number = int.Parse(ReadLine()!);

WriteLine(number>99?$"Третья цифра с конца в этом числе {(number/100)%10}":"Третьей цифры нет ((");