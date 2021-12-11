// Показать кубы чисел, заканчивающихся на четную цифру
int N = 65;
if (0 == N % 2)
{
    while (N > 2)
    {
        Console.WriteLine(N * N * N);
        N -= 2;
    }
}
else
{
    N = N - 1;
    while (N > 2)
    {
        Console.WriteLine(N * N * N);
        N -= 2;
    }
}