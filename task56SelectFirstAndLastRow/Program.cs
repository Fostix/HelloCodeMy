// Написать программу, которая обменивает элементы первой строки и последней строки.

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

void SelectRow(int[,] mrArray, int[,] mrBrainTemt)
{
    for (int row = 0; row < length; row++)
    {
        for (int column = 0; column < length; column++)
        {
            
        }
    }
}



FillArray(array);