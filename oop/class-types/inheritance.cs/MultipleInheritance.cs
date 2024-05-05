
interface IA
{
    public abstract void MethodA();
}

interface IB
{
    public abstract void MethodA();
}

class BaseClass : IA, IB
{
    public void MethodA()
    {
        Console.WriteLine("MethodA implementation in BaseClass");
    }


}

class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of BaseClass
        BaseClass obj = new BaseClass();

        // Calling methods from both interfaces
        obj.MethodA(); // Output: MethodA implementation in BaseClass
    }
}
