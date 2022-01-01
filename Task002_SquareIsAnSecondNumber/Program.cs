Console.Write("Enter first number: ");
double numA = double.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
double numB = double.Parse(Console.ReadLine());
Console.Write("Squard second number: ");
Console.WriteLine(numA);
if(numA == numB * numB)
{
    Console.WriteLine("the first number is the square of the second number");
}
else
{
    Console.WriteLine("the first number is'nt the square of the second number");
}