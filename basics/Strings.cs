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
        String s2 = new String("sagar");

        // == in ref type  compares memory location but in string compiler check if strings have same value clr does string interning
        System.Console.WriteLine(s1.Equals(s2));
        System.Console.WriteLine(s1 == s2);
        System.Console.WriteLine(String.Compare(s1, s2));
        System.Console.WriteLine(ReferenceEquals(s1, s2));

        // string s2 = s1;
        // string s3 = "sagar  thapa";
        // string[] s4 = s3.Split(" ");
        // System.Console.WriteLine(s4.Length);
        // foreach (var s in s4)
        // {
        //     System.Console.WriteLine(s);
        // }

        int[] a = { 1 };
        int[] b = { 1 };
        // System.Console.WriteLine(a.GetHashCode());
        // System.Console.WriteLine(b.GetHashCode());
        // System.Console.WriteLine(a == b);
        // System.Console.WriteLine(object.ReferenceEquals(a, b));




        string? p = (Console.ReadLine());
        string? q = (Console.ReadLine());

        System.Console.WriteLine(p == q);
        System.Console.WriteLine(p.Equals(q));
        System.Console.WriteLine(String.Compare(p, q));
        System.Console.WriteLine(ReferenceEquals(p, q));

    }
}