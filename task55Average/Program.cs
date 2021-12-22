// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

int size = 5;
int zsize = 5;

int[,] array = new int[size, zsize];

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

void Average(int[,] mrArray, int size)
{
    for (int row = 0; row < mrArray.GetLength(0); row++)
    {
        int average = 0;
        for (int column = 0; column < mrArray.GetLength(1); column++)
        {
            average += mrArray[row, column];
        }
        Console.WriteLine(average / size);
    }
}


FillArray(array);
Console.WriteLine();
Console.WriteLine();
Average(array, size);