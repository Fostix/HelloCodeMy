// Написать программу преобразования десятичного числа в двоичное.
int[] arra = new int[1000];
int first = 999,
 second = 2,
 i;

for (i = 0; first > 0; i++)
{
    arra[i] = first % second;
    first = first / second;

}
for (i = i - 1; i >= 0; i--)
{
    Console.Write(arra[i]);
}


/* int binary(int b = 235, z = b)
{
    if (0 == b % 2) return b;
    return binary(b % 2);
    b = b / 2;
} */