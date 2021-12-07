// Найти кубы чисел от 1 до N
Console.Write("Enter number: ");
int length = int.Parse(Console.ReadLine());
length = length + 1;
for (int i = 0; i < length; i++)
{
    int z = i * i * i;
    Console.WriteLine(z);
}