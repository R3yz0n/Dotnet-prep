
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


