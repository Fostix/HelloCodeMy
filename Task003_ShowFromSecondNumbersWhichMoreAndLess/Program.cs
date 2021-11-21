Console.Write("Enter first number: ");
double numA = double.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
double numB = double.Parse(Console.ReadLine());
if(numA > numB)
{
    Console.Write("first number: ");
    Console.Write(numA);
    Console.Write(" more than second number: ");
    Console.Write(numB);
    Console.Write(".");
}
else
{
    Console.Write("first number: ");
    Console.Write(numA);
    Console.Write(" Less than second number: ");
    Console.Write(numB);
    Console.Write(".");
}
