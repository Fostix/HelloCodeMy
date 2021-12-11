// Подсчитать сумму цифр в числе

int n = 69426; //new Random().Next(22, 999);
int sum = 0;
while (n > 1)
{
    sum = n % 10 + sum;
    n = n / 10;
}
Console.WriteLine(sum);