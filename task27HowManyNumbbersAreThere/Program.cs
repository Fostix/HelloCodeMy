// Определить количество цифр в числе.
Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine());
int howManyTimes = 0;
while (number > 1)
{
    number = number / 10;
    howManyTimes++; // Счетчик считает сколько раз поделил
}

// Пока I не будет равен 1 делай
Console.WriteLine(howManyTimes);