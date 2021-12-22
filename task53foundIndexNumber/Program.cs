// В двумерном массиве показать позиции числа, заданного пользователем или указать,
// что такого элемента нет.

int[,] array = new int[9, 9];
Console.Write("Enter name and i find in array: ");
int enterNumber = int.Parse(Console.ReadLine());

int ifNotElements = 0;
for (int row = 0; row < array.GetLength(0); row++)
{
    for (int column = 0; column < array.GetLength(1); column++)
    {
        array[row, column] = new Random().Next(0, 10);
        Console.Write(array[row, column] + " ");
    }
    Console.WriteLine();
}

for (int rowA = 0; rowA < array.GetLength(0); rowA++)
{

    for (int columnA = 0; columnA < array.GetLength(1); columnA++)
    {
        if (array[rowA, columnA] == enterNumber)
        {
            Console.WriteLine("Index element: " + rowA + " " + columnA);
            ifNotElements++;
        }
    }

}
if (ifNotElements < 1)
{
    Console.WriteLine("Not here this element");
}
