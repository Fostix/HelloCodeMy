// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом.

double[] array = new double[10];

void FillArray(double[] fill)
{
    int found = fill.Length;
    for (int i = 0; i < found; i++)
    {
        fill[i] = new Random().Next(1, 1000) / 2.3;
        Console.WriteLine(fill[i]);
    }
}

void FindMinMax(double[] find)
{
    double min = find[0];
    double max = find[0];
    for (int i = 0; i < find.Length; i++)
    {
        if (find[i] < min) min = find[i];
        else if (find[i] > max) max = find[i];
    }
    Console.WriteLine($"max element: {max}, min element: {min}, difference {max - min}");
}



FillArray(array);
FindMinMax(array);