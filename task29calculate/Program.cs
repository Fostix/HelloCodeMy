// Написать программу вычисления произведения чисел от 1 до N

int numberLast = int.Parse(Console.ReadLine());
int saveNumberMinus = numberLast;
while (1 < saveNumberMinus)
{
    numberLast = numberLast * (saveNumberMinus - 1); //factorial
    saveNumberMinus = saveNumberMinus - 1;
}
Console.WriteLine(numberLast);