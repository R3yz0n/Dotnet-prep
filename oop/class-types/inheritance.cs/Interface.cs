//Method and properties are abstract by default
//No need to use overridde keyword
// Cannot be instantiated
interface Shape
{

    public abstract void hi();
    public abstract int Dimensions { get; set; }

}

class Circle : Shape
{
    public void hi()
    {
        System.Console.WriteLine("Hi");
    }

    public int Dimensions { get; set; }
}