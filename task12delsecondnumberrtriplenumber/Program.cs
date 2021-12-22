//Удалить вторую цифру трёхзначного числа

int numTr = new Random().Next(100,999);
Console.WriteLine(numTr);

int numLast = numTr % 10;
numTr = numTr / 100;
numTr = numTr * 10;
numTr = numLast + numTr;

Console.WriteLine(numTr);