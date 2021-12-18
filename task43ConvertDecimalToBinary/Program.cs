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