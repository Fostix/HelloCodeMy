// Возведите число "А" в натуральную степень "B" используя цикл

Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Enter degree: ");
int degree = int.Parse(Console.ReadLine());
int saveNumber = number; // Cохраняет номер.
int howManyTimesToMultiply = 1; // Cтарт счетчика.
while (howManyTimesToMultiply < degree)
{
    number = number * saveNumber;
    howManyTimesToMultiply++;
}

Console.WriteLine(number);