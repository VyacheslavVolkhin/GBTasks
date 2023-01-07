using static System.Console;
Clear();
WriteLine("Введите трехзначное число: ");
int number = int.Parse(ReadLine()!);

while (number<100 || number>999) {
    WriteLine("Введите трехзначное число: ");
    number = int.Parse(ReadLine()!);
}

int a = (number%100)/10;

WriteLine($"Вторая цифра в этом числе {a}");