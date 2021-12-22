// Определить сколько чисел больше 0 введено с клавиатуры.

Console.Write("How much numbers do you want to write? ");
sbyte lengthArray = sbyte.Parse(Console.ReadLine());
int[] array = new int[lengthArray];

for (int i = 0; i < array.Length; i++)
{
    array[i] = int.Parse(Console.ReadLine());
}

for (int j = 0; j < array.Length; j++)
{
    if (array[j] > 0)
    {
        Console.WriteLine($"more than 0 you entered: {array[j]}");
    }
    else
    {
        Console.WriteLine($"Less than 0: {array[j]}");
    }
}