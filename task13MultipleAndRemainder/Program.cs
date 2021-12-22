// Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.Write("Equal: ");
int Equal = int.Parse(Console.ReadLine());
Console.Write("Divider: ");
int Divider = int.Parse(Console.ReadLine());
int Equall = Equal / Divider;
Divider = Equal % Divider;

if (Divider > 0)
{
    Console.WriteLine($"Not multiple, remainder: {Divider}.");
}
else
{
    Console.WriteLine($"Multiple: {Equall}.");
}
