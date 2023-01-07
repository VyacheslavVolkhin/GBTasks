using static System.Console;
Clear();
WriteLine("Введите число не больше 999: ");
int number = int.Parse(ReadLine()!);

while (number>999) {
    WriteLine("Введите число не больше 999: ");
    number = int.Parse(ReadLine()!);
}

WriteLine(number>99?$"Третья цифра в этом числе {number%10}":"Третьей цифры нет ((");