using static System.Console;
Clear();
WriteLine("Введите цифру дня недели (от 1 до 7): ");
int number = int.Parse(ReadLine()!);

while (number>7 || number<1) {
    WriteLine("Введите цифру дня недели (от 1 до 7) ");
    number = int.Parse(ReadLine()!);
}

WriteLine(number==6||number==7?"Да":"Нет");