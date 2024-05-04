//Inner class can access the private members of the outer class
// A nested class can be declared as a private, public, protected, internal, protected internal, or private protected.
// You are allowed to create objects of inner class in outer class.


class OuterClass
{
    int x = 10;

    public OuterClass()
    {
        // InnerClass ic = new InnerClass();
        System.Console.WriteLine("Outer Class");
    }


    public class InnerClass
    {

        // public InnerClass()
        // {
        //     System.Console.WriteLine("Inner Class");
        // }
    }



}