using static System.Console;
Clear();

WriteLine("Введите пятизначное число: ");
bool isNumber = int.TryParse(ReadLine(), out int number);
if (!isNumber) {
    WriteLine("Ошибка");
    return;
}
if (number.ToString().Length != 5) {
    WriteLine("Ошибка");
    return;
}
int a5 = number%10;
int a4 = (number%100)/10;
int a3 = (number%1000)/100;
int a2 = (number%10000)/1000;
int a1 = (number%100000)/10000;

if (a5 == a1 && a4 == a2) {
    WriteLine("Данное число является полиндромом!");
} else {
    WriteLine("Данное число не является полиндромом!");
}