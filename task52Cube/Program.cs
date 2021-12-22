// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

int[,] array = new int[4, 4];

void FillArray(int[,] fill)
{
    for (int i = 0; i < fill.GetLength(0); i++)
    {
        for (int j = 0; j < fill.GetLength(1); j++)
        {
            fill[j, i] = new Random().Next(0, 10);
        }
    }
}

void Cubed(int[,] cubed)
{
    for (int i = 0; i < cubed.GetLength(0); i++)
    {
        for (int j = 0; j < cubed.GetLength(1); j++)
        {
            if (0 == j % 2 & 0 == i % 2)
            {
                cubed[j, i] = cubed[j, i] * cubed[j, i];
            }
        }
    }
}

void PrintArray(int[,] print)
{
    for (int i = 0; i < print.GetLength(0); i++)
    {
        for (int j = 0; j < print.GetLength(1); j++)
        {
            Console.Write(print[j, i] + " ");
        }
        Console.WriteLine();
    }
}

FillArray(array);
Cubed(array);
PrintArray(array);