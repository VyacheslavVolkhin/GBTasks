using static System.Console;
using static System.Math;
Clear();

WriteLine("Введите координату Х точки А: ");
if (!int.TryParse(ReadLine(), out int xa)) {
    WriteLine("Ошибка");
    return;
}
WriteLine("Введите координату Y точки А: ");
if (!int.TryParse(ReadLine(), out int ya)) {
    WriteLine("Ошибка");
    return;
}
WriteLine("Введите координату Z точки А: ");
if (!int.TryParse(ReadLine(), out int za)) {
    WriteLine("Ошибка");
    return;
}
WriteLine("Введите координату Х точки B: ");
if (!int.TryParse(ReadLine(), out int xb)) {
    WriteLine("Ошибка");
    return;
}
WriteLine("Введите координату Y точки B: ");
if (!int.TryParse(ReadLine(), out int yb)) {
    WriteLine("Ошибка");
    return;
}
WriteLine("Введите координату Z точки B: ");
if (!int.TryParse(ReadLine(), out int zb)) {
    WriteLine("Ошибка");
    return;
}

double lineLength = Sqrt(
    Pow((xa-xb), 2) +
    Pow((ya-yb), 2) +
    Pow((za-zb), 2)
);

WriteLine($"Расстояние между заданными точками {lineLength:f2}");