// Показать натуральные числа от 1 до N, N задано.

Console.Write("Enter finish number: ");
int finish = int.Parse(Console.ReadLine());


int RecursionMinus(int finish)
{
    if (finish == 0)
    {
        return finish;
    }
    Console.Write(finish);
    RecursionMinus(finish - 1);
    return finish;
}

RecursionMinus(finish);

