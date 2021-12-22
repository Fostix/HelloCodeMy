Console.Write("First number: ");
double numA = double.Parse(Console.ReadLine());
Console.Write("Second number: ");
double numB = double.Parse(Console.ReadLine());
Console.Write("Third number: ");
double numC = double.Parse(Console.ReadLine());
double max = numA;

if (numB > max) max = numB;
if (numC > max) max = numC;

Console.Write("max number: ");
Console.WriteLine(max);


