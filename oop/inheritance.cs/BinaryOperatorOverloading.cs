// Operator overloading is a compile-time polymorphism. 
// Operator overloading is a feature in object-oriented programming languages like C# that allows you to 
// redefine the behavior of operators when applied to instances of custom types.

class BinaryOperatorOverloading
{
    internal int num;
    internal string? name;


    public static BinaryOperatorOverloading operator +(BinaryOperatorOverloading b1, BinaryOperatorOverloading b2)
    {

        BinaryOperatorOverloading b3 = new BinaryOperatorOverloading();
        b3.num = b1.num + b2.num;
        b3.name = b1.name + b2.name;
        return b3;


    }
}