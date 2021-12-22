//Дано число обозначающее день недели. Выяснить является номер дня недели выходным

string[] arrayD = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
Console.Write("Enter number day: ");
int Day = int.Parse(Console.ReadLine());

if (Day < 32)
{
    Day = Day - 1;
    while (Day > 6)
    {
        Day = Day - 7;
        if (Day > 4)
        {
            Console.WriteLine($"Day weekend: {arrayD[Day]}");
        }
    }
    if (Day < 5)
    {
        Console.WriteLine($"Day: {arrayD[Day]}");
    }
}
else
{
    Console.WriteLine("incorrect day");
}