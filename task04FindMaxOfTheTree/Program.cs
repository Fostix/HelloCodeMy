// Найти максимальное из трех чисел
Console.Write("enter first number: ");
int first = int.Parse(Console.ReadLine());
Console.Write("enter second number: ");
int second = int.Parse(Console.ReadLine());
Console.Write("enter three number: ");
int three = int.Parse(Console.ReadLine());

int max = first;

if (second > max) max = second;
if (three > max) max = three;

Console.Write("this number max of the three numbers: ");
Console.WriteLine(max);