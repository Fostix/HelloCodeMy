// В двумерном массиве n×k заменить четные элементы на противоположные.

int m = 10;
int n = 10;


int[,] array = new int[m, n];

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

void ConvertToEven(int[,] even)
{
    for (int i = 0; i < even.GetLength(0); i++)
    {
        for (int j = 0; j < even.GetLength(1); j++)
        {
            if (0 == even[j, i] % 2)
            {
                even[j, i] = even[j, i]  * -1;
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
ConvertToEven(array);
PrintArray(array);
