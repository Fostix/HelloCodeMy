// Дано число. Проверить кратно ли оно 7 и 23
Console.Write("Enter number: ");
int division = int.Parse(Console.ReadLine());

int f = 7;
int s = 23;
int fTest = division % f;
int sTest = division % s;

if (fTest < 1)
{
    int fEven = division / f;
    Console.WriteLine($"division 7: {fEven}");
}
else
{
    Console.WriteLine("not");
}


if (sTest < 1)
{
    int sEven = division / s;
    Console.WriteLine($"division 23: {sEven}");
}
else
{
    Console.WriteLine("not");
}