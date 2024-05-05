
// Multicast delegate : Hold references to multiple methods having same signature 
// you can chain multiple methods using the "+=" operator;

public delegate int CalculatorDemo(int a, int b);
class MultiCastDelegate
{


    static int Add(int a, int b)
    {
        System.Console.WriteLine("Addition {0}", a + b);

        return a + b;

    }

    static int Multiply(int a, int b)
    {
        System.Console.WriteLine("Multiplication {0}", a * b);
        return a * b;
    }

    public static void Main()
    {
        // instantiate the delegate 
        CalculatorDemo calculator;
        //assigning reference to Add & Multiply method
        calculator = Add;
        calculator += Multiply;

        //Invoking the delegate
        int result = calculator(2, 3);
        System.Console.WriteLine(result);


    }
}