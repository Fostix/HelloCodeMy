// По двум заданным числам проверяет является ли одно квадратом другого

Console.Write("enter first number: ");
int firstN = int.Parse(Console.ReadLine());
Console.Write("enter secon number: ");
int secondN = int.Parse(Console.ReadLine());
if (secondN == firstN * firstN ||firstN == secondN * secondN)
{
    Console.WriteLine("true square");
}
else
{
    Console.WriteLine("not square");
}
