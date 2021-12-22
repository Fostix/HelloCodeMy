// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
Console.Clear();
int X = 2,
    Y = -3;            

if (X > 0 && Y > 0) Console.WriteLine("1");
if (X < 0 && Y > 0) Console.WriteLine("2");
if (X < 0 && Y < 0) Console.WriteLine("3");
if (X > 0 && Y < 0) Console.WriteLine("4");

 