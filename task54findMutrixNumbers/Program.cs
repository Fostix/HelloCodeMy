// В матрице чисел найти сумму элементов главной диагонали.

int[,] array = new int[5, 5];

void FillArray(int[,] fill)
{
    for (int row = 0; row < fill.GetLength(0); row++)
    {
        for (int column = 0; column < fill.GetLength(1); column++)
        {
            fill[row, column] = new Random().Next(0, 10);
            Console.Write(fill[row, column] + " ");
        }
        Console.WriteLine();
    }
}

void FindSumDiagonal(int[,] find)
{
     int sum = 0;
    for (int i = 0; i < find.Length / 5; i++)
    {
        sum += find[i, i];
    }
    Console.WriteLine(sum);
}

FillArray(array);
FindSumDiagonal(array);