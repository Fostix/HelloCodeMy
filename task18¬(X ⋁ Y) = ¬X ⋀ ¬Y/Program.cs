//Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

/* Console.Write("Enter first: ");
bool X = bool.Parse(Console.ReadLine());
Console.Write("Enter number: ");
bool Y = bool.Parse(Console.ReadLine());

if (!(X || Y) == !X && !Y)
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine("false");
} */

/* bool testb()
{
    Console.Write("Enter first: ");
    bool X = bool.Parse(Console.ReadLine());
    Console.Write("Enter number: ");
    bool Y = bool.Parse(Console.ReadLine());
    return !(X || Y) == !X && !Y;
}

bool test = testb();
Console.WriteLine(test); */

bool[] all = {true, false};
bool result = true;

for (int i = 0; i < all.Length; i++)
{
    for (int j = 0; j < all.Length; j++)
    {
        if( !(all[i] || all[j]) == (!all[i] && !all[j]))
        {
            Console.WriteLine($"for X = {all[i]}, Y = {all[j]} true");
        }
        else
        {
            Console.WriteLine($"for X = {all[i]}, Y = {all[j]} false");
            result = false;
            break;
        }
    }
}

if(result)
{
    Console.WriteLine($"true");
}
else
{
    Console.WriteLine($"false");
}