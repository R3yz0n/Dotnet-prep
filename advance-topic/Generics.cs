//Generics allows us to make class and methods type independent.

class Generics
{

    public bool Add<T>(T a, T b)
    {
        if (a.Equals(b))
            return true;
        else return false;
    }

    public static void Main()
    {
        Generics g = new Generics();
        System.Console.WriteLine(g.Add<int>(10, 20));
        System.Console.WriteLine(g.Add<string>("Sagar", "Thapa"));

    }
}