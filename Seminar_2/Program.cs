int Shownumber(int n)
{
    
    int firstnum = n / 10;
    int secondnum = n % 10;


    Console.Write(n + "->");

    if (firstnum > secondnum)
    {
        return firstnum;
    }
    else
    {
        return secondnum;
    }
}
int num = new Random().Next(10, 99);
int a = Shownumber(num);
Console.WriteLine(a);