// Показать кубы чисел, заканчивающихся на четную цифру
int N = 65;

for (int i = N; i > 0; i--)
{
    if (0 == i % 2)
    {
        Console.WriteLine(i * i * i);
    }
}