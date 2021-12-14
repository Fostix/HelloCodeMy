// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] array = new int[123];

void FillArray(int[] write)
{
    int writing = write.Length;
    for (int i = 0; i < writing; i++)
    {
        write[i] = new Random().Next(0, 1000);
    }
}

void PrintArray(int[] printer)
{
    for (int i = 0; i < printer.Length; i++)
    {
        Console.Write(printer[i] + " ");
    }
}

void FindElement(int[] find)
{
    int count = 0;
    for (int i = 0; i < find.Length; i++)
    {
        if (find[i] > 10 & find[i] < 99)
        {
            count++;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"count: {count}");
}

FillArray(array);
PrintArray(array);
FindElement(array);