
// Все числа из ранома выводит и
// ищет "4" и выводит индекс его
// break прерывает после нахождения
// если нет числа в массиве то покажет -1
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int Indexof(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // если число не найдет то покажет что в массиве -1
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break; // иначе покажет последнюю найденую, а не первою
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array); // заполнил массив
array[4] = 4;
array[6] = 4; // принудительно добавил 4

PrintArray(array); // распечатать массив
Console.WriteLine();

int pos =Indexof(array,4);
Console.WriteLine(pos);