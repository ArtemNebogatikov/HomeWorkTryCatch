using SortEvent;

NumberRead numberRead = new NumberRead();
Sort sort = new Sort();
string[] surnames = new string[] { "Васильев", "Петров", "Иванов", "Артемьев", "Григорьев" };
while(true)
{
    try
    {
        var number = numberRead.Read();
        if (number == 1)
        {
            sort.Asc(surnames);
        }
        else if (number == 2)
        {
            sort.Desc(surnames);
        }
        else
        {
            throw new MyExceptions();
        }
    }
    catch (MyExceptions)
    {
        Console.WriteLine("Некорректное значение");
    }
    catch(FormatException)
    {
        Console.WriteLine("Некорректное значение");
    }
}

