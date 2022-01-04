// Показать натуральные числа от M до N, N и M заданы.

Console.Write("Enter firstnumber: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
int secondNumber = int.Parse(Console.ReadLine());


int Rec(int start, int finish)
{
    if (start > finish)
    {
        if (start == finish + 1)
        {
            return 0;
        }
        Console.Write(start + " ");
        return Rec(finish, start + 1);
    }

    if (start == finish + 1)
    {
        return finish;
    }
    Console.Write(finish + " ");
    return Rec(start, finish - 1);
}

Rec(firstNumber, secondNumber);