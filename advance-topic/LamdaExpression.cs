// A lambda expression in C# is an anonymous function that can be used to create delegates or
// expression tree types. Lambda expressions provide a concise way to represent methods as expressions. 
// They are particularly useful in LINQ queries, event handling, and other scenarios where a method is expected as a

using System.Security.Cryptography.X509Certificates;

class LamdaExpression
{



    public static void Main()
    {
        Func<int, int, int> add = (x, y) => x + y;
        int result = add(3, 5);
        System.Console.WriteLine(result);



        Action<string> greet = (name) =>
           {
               Console.WriteLine($"Hello, {name}!");
           };
        greet("John");


        //slect from where // from where select
        var list = new List<int>() { 1, 2, 3, 4, 5 };

        var evenNumbers = from n in list where n % 2 == 0 select n;


    }



}