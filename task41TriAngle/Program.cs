// Выяснить являются ли три числа сторонами треугольника

Console.Write("Enter first number: ");
sbyte a = sbyte.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
sbyte b = sbyte.Parse(Console.ReadLine());
Console.Write("Enter third number: ");
sbyte c = sbyte.Parse(Console.ReadLine());

if (a + b == c || a - b == c) Console.WriteLine("not");
else Console.WriteLine("yes");