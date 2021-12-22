string NumbersFor1(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i >= b; i--)
    {
        result += $"{i} ";
    }
    return result;
}

Console.WriteLine(NumbersFor1(1, 10));