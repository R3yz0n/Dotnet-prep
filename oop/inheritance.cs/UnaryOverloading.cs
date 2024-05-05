class UnaryOverloading
{
    public int num;

    public static UnaryOverloading operator ++(UnaryOverloading u1)
    {
        UnaryOverloading u2 = new UnaryOverloading();
        u2.num = u1.num + 1;
        return u2;

    }
}