string word = "Hello world";
string subword = word.Substring(0, 5);
Console.WriteLine(word);
Console.WriteLine(subword);

int[] array = { 1, 2, 3, 4, 5, 6 };
int[] secondArray = new int[3];

Array.Copy(array, 2, secondArray, 0, secondArray.Length);
for (int i = 0; i < secondArray.Length; i++)
{
    System.Console.WriteLine(secondArray[i] + " ");
}


string getSequence(int number)
{
    if (number == 1)
    {
        return " " + number;
    }
    return getSequence(number - 1) + " " + number;
}

int myNumber = 3;
Console.WriteLine("Привет: "+ getSequence(myNumber));