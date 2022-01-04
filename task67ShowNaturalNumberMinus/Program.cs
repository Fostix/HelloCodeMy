// Показать натуральные числа от N до 1, N задано.

Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine());

int Rec(int num)
{
    if (num == 0) return 0;
    Console.Write(num + " ");
    return Rec(num - 1);
}

Rec(number);