// Показать числа Фибоначчи.
/* 
int fibonacci = int.Parse(Console.ReadLine());

for (int i = 2; i <= fibonacci; i++)
{
    if (fibonacci == 1 || fibonacci == 2)
    {
        Console.WriteLine((fibonacci - 1) + (fibonacci - 2));
    }
    for (int j = 0; j < fibonacci; j++)
    {
        Console.WriteLine(j);
    }

} */





int Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}

for (int i = 1; i < 99; i++)
{
    Console.WriteLine($"({i}) = {Fibonacci(i)}");
}
 

