//Static class can only have static variables,static method and static constructor
// Cannot be instantiated however can initialize the static members with using static constructor
// Cannot be inherited




static class StaticClass
{

    public static int counter;
    //Only called once
    //No access modifier is allowed in static constructor
    //Cannot be Overloaded
    //Autoatically called when the class is loaded by CLR before any static members of the class are accessed.
    static StaticClass()
    {
        counter = 0;
        System.Console.WriteLine("Static constructor called");

    }

    public static void IncrementCounter()
    {
        counter++;
        System.Console.WriteLine("Counter value: " + counter);
    }



}