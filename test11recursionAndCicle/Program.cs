int firstNumber = 321;

string reverse(int number)
{
    if (number < 10)
    {
        return "" + number;
    }
    int lastDigit = number % 10;
    return lastDigit + " " + reverse(number / 10);
}

void reverseByCycle(int number)
{
    while (number > 0)
    {
        Console.Write(number % 10 + " ");
        number /= 10;
    }
}

Console.WriteLine("последовательлность: " + reverse(firstNumber));
reverseByCycle(firstNumber);
Console.WriteLine();

string  forwarded(int number)
{
    if ( number <  10)
    {
        return "" + number;
    }
    int lastDigit = number % 10;
    return forwarded(number / 10) + " " + lastDigit;
}

Console.WriteLine("прямая последовательность: " + forwarded(firstNumber));

