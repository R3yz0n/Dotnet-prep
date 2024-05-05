// A delegate is a type that represents references to methods with a particular parameter list and return type.

using System;

// declare a delegate type
public delegate int MathOperation(int a, int b);

class SingleCastDelegate
{


    // method that matches the delegate signature
    public static int Add(int a, int b) => a + b;

    public static int Subtract(int a, int b)
    {
        return a - b;
    }

    public static void Main()
    {
        // instantiate the delegate       
        MathOperation calculator;
        //assigning reference to Add method
        calculator = Add;

        // invoke the delegate
        int result = calculator(34, 35);
        Console.WriteLine("After addition : {0}", result);

        // re-assign the delegate to Subtract method
        calculator = Subtract;
        result = calculator(45, 33);
        Console.WriteLine("After subtraction: {0}", result);
    }

}