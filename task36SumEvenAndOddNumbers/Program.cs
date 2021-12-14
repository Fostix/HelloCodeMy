// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
Console.Write("Enter array length: ");
int arrayLength = int.Parse(Console.ReadLine());
int[] array = new int[arrayLength];

void FillArray(int[] fill)
{
    int fills = fill.Length;
    for (int i = 0; i < fills; i++)
    {
        fill[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] print)
{
    int prints = print.Length;
    for (int i = 0; i < prints; i++)
    {
        Console.Write(print[i] + " ");
    }
}

void FoundEvenAndOddNumbers(int[] looking)
{
    int look = looking.Length;
    int even = 0;
    int odd = 0;

    for (int i = 0; i < look; i++)
    {
        if (0 == array[i] % 2)
        {
            even++;
        }
        else
        {
            odd++;
        }
    }
    Console.WriteLine($"even: {even}. Odd: {odd}");
}

FillArray(array);
PrintArray(array);
FoundEvenAndOddNumbers(array);