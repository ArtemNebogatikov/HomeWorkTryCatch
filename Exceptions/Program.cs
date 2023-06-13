MyExeption myExeption = new MyExeption("Мое исключение");
ArgumentNullException argumentNull = new ArgumentNullException();
OutOfMemoryException outOfMemory = new OutOfMemoryException();
IndexOutOfRangeException indexOutOfRange = new IndexOutOfRangeException();
OverflowException overflow = new OverflowException();
Exception[] exp = new Exception[]
{
    myExeption,
    argumentNull,
    outOfMemory,
    overflow,
    indexOutOfRange
};
foreach (Exception e in exp)
{

    try
    {
        throw e;
    }
    catch (MyExeption ex)
    {
        Console.WriteLine(ex.Message);
        Console.ReadLine();
    }
    catch (ArgumentNullException ex)
    {
        Console.WriteLine(ex.Message);
        Console.ReadLine();
    }
    catch (OutOfMemoryException ex)
    {
        Console.WriteLine(ex.Message);
        Console.ReadLine();
    }
    catch (IndexOutOfRangeException ex)
    {
        Console.WriteLine(ex.Message);
        Console.ReadLine();
    }
    catch (OverflowException ex)
    {
        Console.WriteLine(ex.Message);
        Console.ReadLine();
    }
}




public class MyExeption : Exception
{
    public MyExeption(string message) : base(message) { }
}