// are used to perform any necessary final clean-up when a class instance is being collected by the garbage collector.
class Finalizer
{

    public Finalizer()
    {
        System.Console.WriteLine("Object construction....");
    }

    public void DoSomething()
    {
        // Use the object passed to the constructor
    }
    ~Finalizer()
    {
        System.Console.WriteLine("Object destruction....");
    }
}