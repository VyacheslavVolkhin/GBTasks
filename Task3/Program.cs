using static System.Console;

WriteLine("Enter digit: ");
int a = int.Parse(ReadLine()!);

if (a == 1) {
    WriteLine("Monday");
} else if (a == 2) {
    WriteLine("Tuesday");
} else if (a == 3) {
    WriteLine("Wednesday");
} else if (a == 4) {
    WriteLine("Thursday");
} else if (a == 5) {
    WriteLine("Friday");
} else if (a == 6) {
    WriteLine("Saturday");
} else if (a == 7) {
    WriteLine("Sunday");
} else {
    WriteLine("No week day");
}