﻿int myMethod()
{
    int a = 2;
    int b = 3;
    return a + b;
}

int c = myMethod();
Console.WriteLine(c);

// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

int[] array = new int[12];

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

int SumPairsNumbers(int[] sum)
{
    int show = 0;
    for (int i = 0; i < sum.Length; i++)
    {
        int sums = 0;
        show++;
        sums = sum[i] * (sum[sum.Length - 1 - i]);
        // TODO: причина не удалось реализовать Console.Write($"{show} {sum.Length}");
        Console.Write(" " + sums);
        return sums;
        return show;
        return i;
        return sum;
    }
    return sum;
}

FillArray(array);
PrintArray(array);
Console.WriteLine();
SumPairsNumbers(array);