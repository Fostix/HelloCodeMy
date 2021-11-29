//Показать числа от -N до N
Console.Write("Enter from number: ");
int from = int.Parse(Console.ReadLine());
Console.Write("Enter stop number: ");
int to = int.Parse(Console.ReadLine());
to = to + 1;

for (int shownumb = from; shownumb < to; shownumb++)
{
    Console.WriteLine(shownumb);
}
