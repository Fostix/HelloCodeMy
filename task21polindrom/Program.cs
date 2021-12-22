// Программа проверяет пятизначное число на палиндромом.
Console.WriteLine("enter number");
int test = int.Parse(Console.ReadLine());

if (test % 10 == test / 10000 && test % 100 / 10 == test / 1000 % 10) Console.WriteLine("Polindrom");
else
{
    Console.WriteLine("Not");
}