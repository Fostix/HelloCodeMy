// Программа проверяет пятизначное число на палиндромом.
Console.WriteLine("enter number");
int test = int.Parse(Console.ReadLine());




if (test > 100000)
{
    int testlast = test / 10000;
    int first = test % 10;
    Console.WriteLine(testlast);
    Console.WriteLine(first);
    if (testlast == first)
    {
        Console.WriteLine("yes");
    }
}



/* Console.WriteLine(test);

int sec = trip % 100; // остаток не просто деление
sec = sec / 10; // обычное деление

Console.Write("second number from triple number: ");
Console.WriteLine(sec); */

/* int numTr = new Random().Next(100,999);
Console.WriteLine(numTr);

int numLast = numTr % 10;
numTr = numTr / 100;
numTr = numTr * 10;
numTr = numLast + numTr;

Console.WriteLine(numTr); */