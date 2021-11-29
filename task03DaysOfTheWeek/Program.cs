//По заданному номеру дня недели вывести его название
string[] numdDay = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
Console.Write("Enter number: and i will write day of the week: ");
int numDay = int.Parse(Console.ReadLine());
numDay = numDay - 1;

if (numDay < 7)
{
    Console.WriteLine(numdDay[numDay]);
    
}
else
{
    numDay = numDay - 7;
}


/* 
for (int i = 99; i > numDay; i=-7)
    Console.WriteLine(i);


 */



/* if (numDay < 7)
{
    Console.WriteLine(numdDay[numDay]);
}
else
{
    numDay = numDay - 7;
    return numdDay;
}
 */





/* Console.Write("and i will write day of the week"); */