// See https://aka.ms/new-console-template for more information

int countFactiorial(int nubmer)
{
    if (nubmer ==1)
    {
        return 1;
    }
    else 
    {
        return nubmer * countFactiorial((nubmer - 1));
    }
}

int x = countFactiorial(20);
Console.WriteLine(x);