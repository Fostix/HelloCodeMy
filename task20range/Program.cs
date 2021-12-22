// Задать номер четверти, показать диапазоны для возможных координат

Console.WriteLine("enter num");
int X = int.Parse(Console.ReadLine());

if (X == 1) Console.WriteLine("1. X (0;999) Y (0;999)");
if (X == 2) Console.WriteLine("2. X (-999;0) Y (0;999)");
if (X == 3) Console.WriteLine("3. X (-999;0) Y (-999;0)");
if (X == 4) Console.WriteLine("4. X (0;999) Y (0;-999)");
else
{
    Console.WriteLine("error!");
}