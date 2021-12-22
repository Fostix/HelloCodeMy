// Написать программу масштабирования фигуры.

double[] array = new double[4];

for (int i = 0; i < array.Length; i++)
{
    array[i] = double.Parse(Console.ReadLine());
}


double scale = double.Parse(Console.ReadLine());

for (int j = 0; j < array.Length; j++)
{
    array[j] *= scale;
    Console.WriteLine("scale: " + array[j]);
}







