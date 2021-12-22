// Определить, присутствует ли в заданном массиве, некоторое число

int[] array = new int[12];

Console.Write("Enter number and i'll look in the array: ");
int findNumber = int.Parse(Console.ReadLine());
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 10);
}
for (int j = 0; j < array.Length; j++)
{
    Console.Write(array[j] + " ");
}
Console.WriteLine();
for (int k = 0; k < array.Length; k++)
{
    if (array[k] == findNumber)
    {
        Console.Write($"I found it index: {k}");
        break;
    }
    if (k == array.Length)
    {
        Console.WriteLine("here not this number");
    }
}