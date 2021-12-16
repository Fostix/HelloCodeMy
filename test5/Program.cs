int[] array = new int [12];

void FillArray(int[] fill)
{
    int filling = fill.Length;
    int index = 0;
    while (index < filling)
    {
        fill[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] print)
{
    int printing = print.Length;
    int index = 0;
    while (index < printing)
    {
        Console.Write(print[index] + " ");  
        index++; 
    }
}

FillArray(array);
PrintArray(array);