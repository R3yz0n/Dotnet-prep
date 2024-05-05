//Cannot be instantiated
//Abstract class needs to have atleast one abstract method
//It can have regular method
// An abstract class in C# is a class that cannot be instantiated directly. It serves as a blueprint for other classes to inherit from
public abstract class AbstractClass
{
    public AbstractClass()
    {
        System.Console.WriteLine("Abstract Class Constructor");
    }
    public abstract void AbstractMethod();
}

public class AbstractionDemo : AbstractClass
{
    public override void AbstractMethod()
    {
        System.Console.WriteLine("Abstract Method");
    }
}


