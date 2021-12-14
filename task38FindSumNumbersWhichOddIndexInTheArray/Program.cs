// Найти сумму чисел одномерного массива стоящих на нечетной позиции

int[] array = new int[10];

void FillArray(int[] fill)
{
    for (int i = 0; i < fill.Length; i++)
    {
        fill[i] = new Random().Next(0, 100);
    }
}

void PrintArray(int[] print)
{
    for (int i = 0; i < print.Length; i++)
    {
        Console.Write(print[i] + " ");
    }
}

void OddIndexPosition(int[] oddPosition)
{
    Console.WriteLine();
    int sum = 0;
    for (int i = 0; i < oddPosition.Length; i++)
    {
        if (0 != i % 2)
        {
            sum += oddPosition[i];
        }
    }
    Console.Write($"sum odd numbers: {sum}");
}


FillArray(array);
PrintArray(array);
OddIndexPosition(array);