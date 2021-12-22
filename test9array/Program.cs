int[,] doubleArray = new int[2, 4];
int[,] another = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };

Console.WriteLine(another[0, 1]);

void printDoubleArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            Console.Write(array[row, column] + " ");
        }
        Console.WriteLine();
    }
}

printDoubleArray(another);
Console.WriteLine();
printDoubleArray(doubleArray);
Console.WriteLine();

int[][] jaggedArray = new int[3][];
jaggedArray[0] = new int[2];
jaggedArray[1] = new int[3];
jaggedArray[2] = new int[1];

void fillArray(int[][] array)
{
    for (int row = 0; row < array.Length; row++)
    {
        for (int column = 0; column < array[row].Length; column++)
        {
            array[row][column] = (row + 1) * (column + 1);
        }
    }
}

void printJaggedArray(int[][] array)
{
    for (int row = 0; row < array.Length; row++)
    {
        for (int column = 0; column < array[row].Length; column++)
        {
            Console.Write(array[row][column] + " ");
        }
        Console.WriteLine();
    }
}


printJaggedArray(jaggedArray);
fillArray(jaggedArray);
Console.WriteLine();
printJaggedArray(jaggedArray);
