// A nested class can be declared as a private, public, protected, internal, protected internal, or private protected.
//Inner class can use static members and static methods of the outer class directly.
//Inner class can access the private protected members of the outer class not vice versa.
//Access of inner class members is possible only through the instance of the outer class.


class OuterClass
{

    int outerVariable = 2000;
    public OuterClass()
    {
        System.Console.WriteLine("Outer Class");
        InnerClass ic = new InnerClass();
        System.Console.WriteLine(ic.innerVariable);

    }



    internal class InnerClass
    {
        public int innerVariable = 10;

        public InnerClass()
        {

            System.Console.WriteLine("Inner Class");
        }


    }



}