// Показать таблицу квадратов чисел от 1 до N

Console.Write("enter: ");
int hello = int.Parse(Console.ReadLine());
hello = hello + 1;
for (int i = 1; i < hello; i++)
{
    int  a = i * i;
    Console.WriteLine(a);
}