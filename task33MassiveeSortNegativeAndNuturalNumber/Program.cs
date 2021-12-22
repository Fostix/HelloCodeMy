// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

int[] array = new int[11];
int negativeSum = 0;
int positiveSum = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9, 9);
    Console.Write(array[i] + " ");
    if (array[i] > 0) positiveSum += array[i];
    else negativeSum = negativeSum += array[i];
}
Console.WriteLine();
Console.WriteLine(positiveSum);
Console.WriteLine(negativeSum);