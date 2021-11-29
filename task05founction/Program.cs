//Написать программу вычисления значения функции y = f(a)
Console.Write("Enter first number: ");
int f = int.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
int a = int.Parse(Console.ReadLine());


int y = Convert.ToInt32(Math.Pow(f, a));
y = y + 1;
Console.Write("hello: ");
Console.WriteLine(y);