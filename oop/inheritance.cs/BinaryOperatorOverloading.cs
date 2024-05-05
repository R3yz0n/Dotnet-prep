class BinaryOperatorOverloading
{
    internal int num;
    internal string? name;
    public static BinaryOperatorOverloading operator +(BinaryOperatorOverloading obj1, BinaryOperatorOverloading obj2)
    {
        System.Console.WriteLine("hi");
        BinaryOperatorOverloading obj3 = new BinaryOperatorOverloading();
        obj3.num = obj1.num + obj2.num;
        obj3.name = obj1.name + obj2.name;
        return obj3;
    }


}