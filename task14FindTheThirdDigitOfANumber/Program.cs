// Найти третью цифру числа или сообщить, что её нет
// 2 147 483 647
Console.Write("Enter number: ");
int Trip = int.Parse(Console.ReadLine());

if (Trip < -99)
{
    Trip = Trip / -10;
}
while (Trip > 1000)
{
    Trip = Trip / 10; 
}

if (Trip > 99)
{
    Trip = Trip % 10;
    Console.WriteLine($"Triple number: {Trip}");
}
else
{
    Console.WriteLine("Not thiple number!");
}