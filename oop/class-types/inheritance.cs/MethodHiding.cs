// It hides the method of the base class. It is known as method hiding in C#.
// It helps to redefine method in the derived class.
//It prints the method of the base class

class Base
{

    public void Display()
    {
        Console.WriteLine("Base Display");
    }

}

class Derived : Base
{

    public new void Display()
    {
        Console.WriteLine("Derived Display");
    }

}