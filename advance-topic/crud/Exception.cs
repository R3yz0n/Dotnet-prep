class Exception
{
    // System.NullReferenceException:
    //OutOfMemoryException

    public static void Main()
    {
        int num = 1;
        try
        {
            int result = num / 0;
            throw new DivideByZeroException("Divide by zero exception");

        }
        catch (DivideByZeroException ex)
        {
            System.Console.WriteLine(ex.Message);
        }
        finally
        {
            System.Console.WriteLine("Finally block executed");
        }

    }
}