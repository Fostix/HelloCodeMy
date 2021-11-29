// Показать вторую цифру трёхзначного числа
Console.Write("Enter triple number: ");
int trip = int.Parse(Console.ReadLine());

int sec = trip % 100; // остаток не просто деление
sec = sec / 10; // обычное деление

Console.Write("second number from triple number: ");
Console.WriteLine(sec);