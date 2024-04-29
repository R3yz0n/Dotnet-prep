class Goto
{
    public Goto()
    {
        int a = 0;

    labelx:;
        if (a < 5)
        {
            System.Console.WriteLine(a);
            a++;
            goto labelx;
        }
    }
}