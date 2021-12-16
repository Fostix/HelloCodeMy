// Написать программу замену элементов массива на противоположные.

int[] array = new int[22];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9, 9);
    Console.Write(array[i] + "     ");
    if (array[i] < 0)
    {
        array[i] =  -array[i];
        Console.WriteLine(array[i]);
    }
    else
    {
        array[i] = -array[i];
        Console.WriteLine(array[i]);
    }
}
