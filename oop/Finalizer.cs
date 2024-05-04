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