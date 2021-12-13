// Показать четные числа от 1 до N
Console.WriteLine("enter finite number: ");
int finite = int.Parse(Console.ReadLine());
Console.WriteLine(1);

for (int i = 1; i <= finite; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}