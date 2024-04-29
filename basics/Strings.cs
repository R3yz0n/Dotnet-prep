using System.Security.Cryptography;

class Strings
{
    public Strings()
    {

        //String methos (static)
        // Compare Concat

        //String methos (non-static)
        //Equals ToUpper Trim IndexOf

        // s1.equals(s2) 
        // String.Compare(s1,s2)

        string s1 = "sagar";
        string s2 = "sagar";

        System.Console.WriteLine(s1.Equals(s2));
        System.Console.WriteLine(String.Compare(s1, s2));

        // string s2 = s1;
        // string s3 = "     sagar  thapa    ";
        // System.Console.WriteLine(s1.ToUpper());
        // System.Console.WriteLine(s3.Trim());
        // System.Console.WriteLine(s3.Split(" "));
        // string[] s4 = s3.Split(" ");
        // System.Console.WriteLine(s4[0]);
        // System.Console.WriteLine(s4[1]);
        int[] a = { 1 };
        int[] b = { 1 };
        // System.Console.WriteLine(a.GetHashCode());
        // System.Console.WriteLine(b.GetHashCode());
        // System.Console.WriteLine(a == b);
        // System.Console.WriteLine(object.ReferenceEquals(a, b));


        System.Console.WriteLine(string.Equals(s1, s2));


        // Conclusion
        /*

        */

    }
}