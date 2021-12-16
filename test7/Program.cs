int A = 100;
int B = 150;

void PrintNum(int a, int b)
{
    Console.Write(a + " ");
    if (a < b)
    {
        PrintNum(a + 1, b);
    }
    if (a > b)
    {
        PrintNum(a - 1, b);
    }
}

PrintNum(A, B);