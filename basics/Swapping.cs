class Swapping
{
    public Swapping()
    {
        int a = 10;
        int b = 20;
        System.Console.WriteLine($"Before swapping: a = {a}, b = {b}", a, b);
        changeValue(ref a, ref b);
        System.Console.WriteLine($"After swapping: a = {a}, b = {b}", a, b);

    }
    void changeValue(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
}